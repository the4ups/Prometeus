namespace peopleapi.Models
{
    using System;

    [Serializable]
    public class People
    {
        public People()
        {
            this.personId = Guid.NewGuid();
        }

        public Guid personId { get; set; }

        public string firstname { get; set; }

        public string middlename { get; set; }

        public string lastname { get; set; }

        public string title { get; set; }

        public string suffix { get; set; }
    }
}