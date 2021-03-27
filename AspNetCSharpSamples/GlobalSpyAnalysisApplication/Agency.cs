namespace GlobalSpyAnalysisApplication
{
    class Agency
    {
        private string agencyName;
        private int organizationSize;
        private string country;

        public string AgencyName
        {
            get
            { return agencyName; }

            set { agencyName = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public int OrganizationSize
        {
            get { return organizationSize; }
            set { organizationSize = value; }
        }

        public string GetAgencyInfo()
        {
            string message = "";
            message = AgencyName + " " + "(" + Country + " ) + Size: " + OrganizationSize;
            return message;
        }
    }
}
