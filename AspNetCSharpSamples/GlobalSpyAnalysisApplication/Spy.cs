using System;

namespace GlobalSpyAnalysisApplication
{
    class Spy
    {
        private string codeName;
        private DateTime dateLastSeen;
        private Agency agency;
        private string notes;

        public string CodeName
        {
            get
            {
                return codeName;
            }
            set { codeName = value; }
        }

        public DateTime DateLastSeen
        {
            get { return dateLastSeen; }
            set { dateLastSeen = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Agency SpyAgency
        {
            get
            {
                return agency;
            }
            set { agency = value; }
        }
        public void DisplaySpyInfo()
        {
            Console.WriteLine(CodeName + "{" + SpyAgency.GetAgencyInfo() + "} ...Last Seen : " + DateLastSeen.ToString() + " {" + Notes + "}");
        }
    }
}