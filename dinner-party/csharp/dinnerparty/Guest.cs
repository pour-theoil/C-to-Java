namespace dinnerparty{
    class Guest 
    {
        public string Name { get; } 
        public string Occupation { get; }
        public string Bio { get; }

        public Guest(string name, string occu, string bio )
        {
            Name = name;
            Occupation = occu;
            Bio = bio;
        }
    }
}