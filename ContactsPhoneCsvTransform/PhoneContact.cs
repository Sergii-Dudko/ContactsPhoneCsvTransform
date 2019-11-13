using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsPhoneCsvTransform
{
    public class PhoneContact
    {
        private Dictionary<string, string> columnValuePairs;

        public PhoneContact()
        {
            this.columnValuePairs = new Dictionary<string, string>();
        }

        public string GivenName { get; set; }

        public string AdditionalName { get; set; }

        public string FamilyName { get; set; }

        public string NameSuffix { get; set; }

        public string OrgName { get; set; }

        public string OrgDepartment { get; set; }

        public string OrgTitle { get; set; }

        public string AdrWorkStreet { get; set; }

        public string AdrWorkStreetExt { get; set; }

        public string AdrWorkCity { get; set; }

        public string AdrWorkRegion { get; set; }

        public string AdrWorkPostalCode { get; set; }

        public string AdrWorkCountry { get; set; }

        public string AdrHomeStreet { get; set; }

        public string AdrHomeStreetExt { get; set; }

        public string AdrHomeCity { get; set; }

        public string AdrHomeRegion { get; set; }

        public string AdrHomePostalCode { get; set; }

        public string AdrHomeCountry { get; set; }

        public string AdrOtherStreet { get; set; }

        public string AdrOtherStreetExt { get; set; }

        public string AdrOtherCity { get; set; }

        public string AdrOtherRegion { get; set; }

        public string AdrOtherPostalCode { get; set; }

        public string AdrOtherCountry { get; set; }

        public string WorkFax { get; set; }

        public string WorkPhone { get; set; }

        public string WorkPhone2 { get; set; }

        public string CarPhone { get; set; }

        public string HomeFax { get; set; }

        public string HomePhone { get; set; }

        public string HomePhone2 { get; set; }

        public string MobilePhone { get; set; }

        public string OtherPhone { get; set; }

        public string Pager { get; set; }

        public string MainPhone { get; set; }

        public string RadioPhone { get; set; }

        public string WebSite { get; set; }

        public string Anniversary { get; set; }

        public string Birthday { get; set; }

        public string Child { get; set; }

        public string Notes { get; set; }

        public string Assistant { get; set; }

        public string Initials { get; set; }

        public string Spouse { get; set; }

        public string E_mail { get; set; }

        public string E_mail2 { get; set; }

        public Dictionary<string, string> ColumnValuePairs
        {
            get
            {
                return columnValuePairs.Count > 0 ? columnValuePairs : FillColumnValuePairs();
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var valuePair in ColumnValuePairs)
            {
                stringBuilder.Append(valuePair.Key).Append(":").Append(valuePair.Value).Append("\n");
            }

            return stringBuilder.ToString();
        }

        private Dictionary<string, string> FillColumnValuePairs()
        {
            columnValuePairs.Add("GivenName", GivenName);
            columnValuePairs.Add("AdditionalName", AdditionalName);
            columnValuePairs.Add("FamilyName", FamilyName);
            columnValuePairs.Add("NameSuffix", NameSuffix);
            columnValuePairs.Add("OrgName", OrgName);
            columnValuePairs.Add("OrgDepartment", OrgDepartment);
            columnValuePairs.Add("OrgTitle", OrgTitle);
            columnValuePairs.Add("AdrWorkStreet", AdrWorkStreet);
            columnValuePairs.Add("AdrWorkStreetExt", AdrWorkStreetExt);
            columnValuePairs.Add("AdrWorkCity", AdrWorkCity);
            columnValuePairs.Add("AdrWorkRegion", AdrWorkRegion);
            columnValuePairs.Add("AdrWorkPostalCode", AdrWorkPostalCode);
            columnValuePairs.Add("AdrWorkCountry", AdrWorkCountry);
            columnValuePairs.Add("AdrHomeStreet", AdrHomeStreet);
            columnValuePairs.Add("AdrHomeStreetExt", AdrHomeStreetExt);
            columnValuePairs.Add("AdrHomeCity", AdrHomeCity);
            columnValuePairs.Add("AdrHomeRegion", AdrHomeRegion);
            columnValuePairs.Add("AdrHomePostalCode", AdrHomePostalCode);
            columnValuePairs.Add("AdrHomeCountry", AdrHomeCountry);
            columnValuePairs.Add("AdrOtherStreet", AdrOtherStreet);
            columnValuePairs.Add("AdrOtherStreetExt", AdrOtherStreetExt);
            columnValuePairs.Add("AdrOtherCity", AdrOtherCity);
            columnValuePairs.Add("AdrOtherRegion", AdrOtherRegion);
            columnValuePairs.Add("AdrOtherPostalCode", AdrOtherPostalCode);
            columnValuePairs.Add("AdrOtherCountry", AdrOtherCountry);
            columnValuePairs.Add("WorkFax", WorkFax);
            columnValuePairs.Add("WorkPhone", WorkPhone);
            columnValuePairs.Add("WorkPhone2", WorkPhone2);
            columnValuePairs.Add("CarPhone", CarPhone);
            columnValuePairs.Add("HomeFax", HomeFax);
            columnValuePairs.Add("HomePhone", HomePhone);
            columnValuePairs.Add("HomePhone2", HomePhone2);
            columnValuePairs.Add("MobilePhone", MobilePhone);
            columnValuePairs.Add("OtherPhone", OtherPhone);
            columnValuePairs.Add("Pager", Pager);
            columnValuePairs.Add("MainPhone", MainPhone);
            columnValuePairs.Add("RadioPhone", RadioPhone);
            columnValuePairs.Add("WebSite", WebSite);
            columnValuePairs.Add("Anniversary", Anniversary);
            columnValuePairs.Add("Birthday", Birthday);
            columnValuePairs.Add("Child", Child);
            columnValuePairs.Add("Notes", Notes);
            columnValuePairs.Add("Assistant", Assistant);
            columnValuePairs.Add("Initials", Initials);
            columnValuePairs.Add("Spouse", Spouse);
            columnValuePairs.Add("E_mail", E_mail);
            columnValuePairs.Add("E_mail2", E_mail2);

            return columnValuePairs;
        }


        public string CombineVal(List<string> columnsName)
        {
            StringBuilder stringBuilder = new StringBuilder().Clear();
            int columnCount = columnsName.Count;

            if (columnsName != null)
            {
                if (columnCount > 0)
                {
                    string[] names = columnsName.ToArray<string>();
                    for (int i = 0; i < columnCount; i++)
                    {
                        string value = this.ColumnValuePairs[names[i]];
                        if (columnCount < 2)
                        {
                            if (string.IsNullOrEmpty(value))
                                stringBuilder.Append("");
                            else
                                stringBuilder.Append(value);
                        }
                        else
                        {
                            if (i == 0)
                            {
                                string valueNext = this.ColumnValuePairs[names[i + 1]];
                                if (string.IsNullOrEmpty(value) && string.IsNullOrEmpty(valueNext))
                                    stringBuilder.Append("");
                                else if (string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(valueNext))
                                    stringBuilder.Append("");
                                else if (!string.IsNullOrEmpty(value) && string.IsNullOrEmpty(valueNext))
                                    stringBuilder.Append(value);
                                else
                                    stringBuilder.Append(value).Append(" ::: ");
                            }
                            else if (i > 0 && i < columnCount - 1)
                            {

                            }
                            else
                            {
                                if (string.IsNullOrEmpty(value))
                                    stringBuilder.Append("");
                                else
                                    stringBuilder.Append(value);
                            }

                        }
                    }
                }
            }

            return stringBuilder.ToString();
        }

    }
}
