using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsPhoneCsvTransform
{
    public class PhoneContactGoogle
    {

        private Dictionary<string, string> columnValuePairs;

        public PhoneContactGoogle()
        {
            this.columnValuePairs = new Dictionary<string, string>();
        }

        public string Name { get; set; }
        public string GivenName { get; set; }
        public string AdditionalName { get; set; }
        public string FamilyName { get; set; }
        public string YomiName { get; set; }
        public string GivenNameYomi { get; set; }
        public string AdditionalNameYomi { get; set; }
        public string FamilyNameYomi { get; set; }
        public string NamePrefix { get; set; }
        public string NameSuffix { get; set; }
        public string Initials { get; set; }
        public string Nickname { get; set; }
        public string ShortName { get; set; }
        public string MaidenName { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string BillingInformation { get; set; }
        public string DirectoryServer { get; set; }
        public string Mileage { get; set; }
        public string Occupation { get; set; }
        public string Hobby { get; set; }
        public string Sensitivity { get; set; }
        public string Priority { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public string Language { get; set; }
        public string Photo { get; set; }
        public string GroupMembership { get; set; }
        public string E_mail1_Type { get; set; }
        public string E_mail1_Value { get; set; }
        public string E_mail2_Type { get; set; }
        public string E_mail2_Value { get; set; }
        public string E_mail3_Type { get; set; }
        public string E_mail3_Value { get; set; }
        public string IM1_Type { get; set; }
        public string IM1_Service { get; set; }
        public string IM1_Value { get; set; }
        public string Phone1_Type { get; set; }
        public string Phone1_Value { get; set; }
        public string Phone2_Type { get; set; }
        public string Phone2_Value { get; set; }
        public string Phone3_Type { get; set; }
        public string Phone3_Value { get; set; }
        public string Phone4_Type { get; set; }
        public string Phone4_Value { get; set; }
        public string Phone5_Type { get; set; }
        public string Phone5_Value { get; set; }
        public string Phone6_Type { get; set; }
        public string Phone6_Value { get; set; }
        public string Phone7_Type { get; set; }
        public string Phone7_Value { get; set; }
        public string Phone8_Type { get; set; }
        public string Phone8_Value { get; set; }
        public string Phone9_Type { get; set; }
        public string Phone9_Value { get; set; }
        public string Address1_Type { get; set; }
        public string Address1_Formatted { get; set; }
        public string Address1_Street { get; set; }
        public string Address1_City { get; set; }
        public string Address1_POBox { get; set; }
        public string Address1_Region { get; set; }
        public string Address1_PostalCode { get; set; }
        public string Address1_Country { get; set; }
        public string Address1_ExtendedAddress { get; set; }
        public string Address2_Type { get; set; }
        public string Address2_Formatted { get; set; }
        public string Address2_Street { get; set; }
        public string Address2_City { get; set; }
        public string Address2_POBox { get; set; }
        public string Address2_Region { get; set; }
        public string Address2_PostalCode { get; set; }
        public string Address2_Country { get; set; }
        public string Address2_ExtendedAddress { get; set; }
        public string Address3_Type { get; set; }
        public string Address3_Formatted { get; set; }
        public string Address3_Street { get; set; }
        public string Address3_City { get; set; }
        public string Address3_POBox { get; set; }
        public string Address3_Region { get; set; }
        public string Address3_PostalCode { get; set; }
        public string Address3_Country { get; set; }
        public string Address3_ExtendedAddress { get; set; }
        public string Organization1_Type { get; set; }
        public string Organization1_Name { get; set; }
        public string Organization1_YomiName { get; set; }
        public string Organization1_Title { get; set; }
        public string Organization1_Department { get; set; }
        public string Organization1_Symbol { get; set; }
        public string Organization1_Location { get; set; }
        public string Organization1_JobDescription { get; set; }
        public string Relation1_Type { get; set; }
        public string Relation1_Value { get; set; }
        public string Relation2_Type { get; set; }
        public string Relation2_Value { get; set; }
        public string Relation3_Type { get; set; }
        public string Relation3_Value { get; set; }
        public string Relation4_Type { get; set; }
        public string Relation4_Value { get; set; }
        public string Relation5_Type { get; set; }
        public string Relation5_Value { get; set; }
        public string Relation6_Type { get; set; }
        public string Relation6_Value { get; set; }
        public string Relation7_Type { get; set; }
        public string Relation7_Value { get; set; }
        public string Relation8_Type { get; set; }
        public string Relation8_Value { get; set; }
        public string Relation9_Type { get; set; }
        public string Relation9_Value { get; set; }
        public string Relation10_Type { get; set; }
        public string Relation10_Value { get; set; }
        public string Relation11_Type { get; set; }
        public string Relation11_Value { get; set; }
        public string Relation12_Type { get; set; }
        public string Relation12_Value { get; set; }
        public string Relation13_Type { get; set; }
        public string Relation13_Value { get; set; }
        public string Relation14_Type { get; set; }
        public string Relation14_Value { get; set; }
        public string Website1_Type { get; set; }
        public string Website1_Value { get; set; }
        public string Website2_Type { get; set; }
        public string Website2_Value { get; set; }
        public string Website3_Type { get; set; }
        public string Website3_Value { get; set; }
        public string Website4_Type { get; set; }
        public string Website4_Value { get; set; }
        public string Event1_Type { get; set; }
        public string Event1_Value { get; set; }
        public string Event2_Type { get; set; }
        public string Event2_Value { get; set; }
        public string Event3_Type { get; set; }
        public string Event3_Value { get; set; }
        public string CustomField1_Type { get; set; }
        public string CustomField1_Value { get; set; }
        public string CustomField2_Type { get; set; }
        public string CustomField2_Value { get; set; }

        public Dictionary<string, string> ColumnValuePairs
        {
            get
            {
                return columnValuePairs.Count > 0 ? columnValuePairs : FillColumnValuePairs();
            }
        }

        private Dictionary<string, string> FillColumnValuePairs()
        {
            columnValuePairs.Add("Name", Name);
            columnValuePairs.Add("GivenName", GivenName);
            columnValuePairs.Add("AdditionalName", AdditionalName);
            columnValuePairs.Add("FamilyName", FamilyName);
            columnValuePairs.Add("YomiName", YomiName);
            columnValuePairs.Add("GivenNameYomi", GivenNameYomi);
            columnValuePairs.Add("AdditionalNameYomi", AdditionalNameYomi);
            columnValuePairs.Add("FamilyNameYomi", FamilyNameYomi);
            columnValuePairs.Add("NamePrefix", NamePrefix);
            columnValuePairs.Add("NameSuffix", NameSuffix);
            columnValuePairs.Add("Initials", Initials);
            columnValuePairs.Add("Nickname", Nickname);
            columnValuePairs.Add("ShortName", ShortName);
            columnValuePairs.Add("MaidenName", MaidenName);
            columnValuePairs.Add("Birthday", Birthday);
            columnValuePairs.Add("Gender", Gender);
            columnValuePairs.Add("Location", Location);
            columnValuePairs.Add("BillingInformation", BillingInformation);
            columnValuePairs.Add("DirectoryServer", DirectoryServer);
            columnValuePairs.Add("Mileage", Mileage);
            columnValuePairs.Add("Occupation", Occupation);
            columnValuePairs.Add("Hobby", Hobby);
            columnValuePairs.Add("Sensitivity", Sensitivity);
            columnValuePairs.Add("Priority", Priority);
            columnValuePairs.Add("Subject", Subject);
            columnValuePairs.Add("Notes", Notes);
            columnValuePairs.Add("Language", Language);
            columnValuePairs.Add("Photo", Photo);
            columnValuePairs.Add("GroupMembership", GroupMembership);
            columnValuePairs.Add("E_mail1_Type", E_mail1_Type);
            columnValuePairs.Add("E_mail1_Value", E_mail1_Value);
            columnValuePairs.Add("E_mail2_Type", E_mail2_Type);
            columnValuePairs.Add("E_mail2_Value", E_mail2_Value);
            columnValuePairs.Add("E_mail3_Type", E_mail3_Type);
            columnValuePairs.Add("E_mail3_Value", E_mail3_Value);
            columnValuePairs.Add("IM1_Type", IM1_Type);
            columnValuePairs.Add("IM1_Service", IM1_Service);
            columnValuePairs.Add("IM1_Value", IM1_Value);
            columnValuePairs.Add("Phone1_Type", Phone1_Type);
            columnValuePairs.Add("Phone1_Value", Phone1_Value);
            columnValuePairs.Add("Phone2_Type", Phone2_Type);
            columnValuePairs.Add("Phone2_Value", Phone2_Value);
            columnValuePairs.Add("Phone3_Type", Phone3_Type);
            columnValuePairs.Add("Phone3_Value", Phone3_Value);
            columnValuePairs.Add("Phone4_Type", Phone4_Type);
            columnValuePairs.Add("Phone4_Value", Phone4_Value);
            columnValuePairs.Add("Phone5_Type", Phone5_Type);
            columnValuePairs.Add("Phone5_Value", Phone5_Value);
            columnValuePairs.Add("Phone6_Type", Phone6_Type);
            columnValuePairs.Add("Phone6_Value", Phone6_Value);
            columnValuePairs.Add("Phone7_Type", Phone7_Type);
            columnValuePairs.Add("Phone7_Value", Phone7_Value);
            columnValuePairs.Add("Phone8_Type", Phone8_Type);
            columnValuePairs.Add("Phone8_Value", Phone8_Value);
            columnValuePairs.Add("Phone9_Type", Phone9_Type);
            columnValuePairs.Add("Phone9_Value", Phone9_Value);
            columnValuePairs.Add("Address1_Type", Address1_Type);
            columnValuePairs.Add("Address1_Formatted", Address1_Formatted);
            columnValuePairs.Add("Address1_Street", Address1_Street);
            columnValuePairs.Add("Address1_City", Address1_City);
            columnValuePairs.Add("Address1_POBox", Address1_POBox);
            columnValuePairs.Add("Address1_Region", Address1_Region);
            columnValuePairs.Add("Address1_PostalCode", Address1_PostalCode);
            columnValuePairs.Add("Address1_Country", Address1_Country);
            columnValuePairs.Add("Address1_ExtendedAddress", Address1_ExtendedAddress);
            columnValuePairs.Add("Address2_Type", Address2_Type);
            columnValuePairs.Add("Address2_Formatted", Address2_Formatted);
            columnValuePairs.Add("Address2_Street", Address2_Street);
            columnValuePairs.Add("Address2_City", Address2_City);
            columnValuePairs.Add("Address2_POBox", Address2_POBox);
            columnValuePairs.Add("Address2_Region", Address2_Region);
            columnValuePairs.Add("Address2_PostalCode", Address2_PostalCode);
            columnValuePairs.Add("Address2_Country", Address2_Country);
            columnValuePairs.Add("Address2_ExtendedAddress", Address2_ExtendedAddress);
            columnValuePairs.Add("Address3_Type", Address3_Type);
            columnValuePairs.Add("Address3_Formatted", Address3_Formatted);
            columnValuePairs.Add("Address3_Street", Address3_Street);
            columnValuePairs.Add("Address3_City", Address3_City);
            columnValuePairs.Add("Address3_POBox", Address3_POBox);
            columnValuePairs.Add("Address3_Region", Address3_Region);
            columnValuePairs.Add("Address3_PostalCode", Address3_PostalCode);
            columnValuePairs.Add("Address3_Country", Address3_Country);
            columnValuePairs.Add("Address3_ExtendedAddress", Address3_ExtendedAddress);
            columnValuePairs.Add("Organization1_Type", Organization1_Type);
            columnValuePairs.Add("Organization1_Name", Organization1_Name);
            columnValuePairs.Add("Organization1_YomiName", Organization1_YomiName);
            columnValuePairs.Add("Organization1_Title", Organization1_Title);
            columnValuePairs.Add("Organization1_Department", Organization1_Department);
            columnValuePairs.Add("Organization1_Symbol", Organization1_Symbol);
            columnValuePairs.Add("Organization1_Location", Organization1_Location);
            columnValuePairs.Add("Organization1_JobDescription", Organization1_JobDescription);
            columnValuePairs.Add("Relation1_Type", Relation1_Type);
            columnValuePairs.Add("Relation1_Value", Relation1_Value);
            columnValuePairs.Add("Relation2_Type", Relation2_Type);
            columnValuePairs.Add("Relation2_Value", Relation2_Value);
            columnValuePairs.Add("Relation3_Type", Relation3_Type);
            columnValuePairs.Add("Relation3_Value", Relation3_Value);
            columnValuePairs.Add("Relation4_Type", Relation4_Type);
            columnValuePairs.Add("Relation4_Value", Relation4_Value);
            columnValuePairs.Add("Relation5_Type", Relation5_Type);
            columnValuePairs.Add("Relation5_Value", Relation5_Value);
            columnValuePairs.Add("Relation6_Type", Relation6_Type);
            columnValuePairs.Add("Relation6_Value", Relation6_Value);
            columnValuePairs.Add("Relation7_Type", Relation7_Type);
            columnValuePairs.Add("Relation7_Value", Relation7_Value);
            columnValuePairs.Add("Relation8_Type", Relation8_Type);
            columnValuePairs.Add("Relation8_Value", Relation8_Value);
            columnValuePairs.Add("Relation9_Type", Relation9_Type);
            columnValuePairs.Add("Relation9_Value", Relation9_Value);
            columnValuePairs.Add("Relation10_Type", Relation10_Type);
            columnValuePairs.Add("Relation10_Value", Relation10_Value);
            columnValuePairs.Add("Relation11_Type", Relation11_Type);
            columnValuePairs.Add("Relation11_Value", Relation11_Value);
            columnValuePairs.Add("Relation12_Type", Relation12_Type);
            columnValuePairs.Add("Relation12_Value", Relation12_Value);
            columnValuePairs.Add("Relation13_Type", Relation13_Type);
            columnValuePairs.Add("Relation13_Value", Relation13_Value);
            columnValuePairs.Add("Relation14_Type", Relation14_Type);
            columnValuePairs.Add("Relation14_Value", Relation14_Value);
            columnValuePairs.Add("Website1_Type", Website1_Type);
            columnValuePairs.Add("Website1_Value", Website1_Value);
            columnValuePairs.Add("Website2_Type", Website2_Type);
            columnValuePairs.Add("Website2_Value", Website2_Value);
            columnValuePairs.Add("Website3_Type", Website3_Type);
            columnValuePairs.Add("Website3_Value", Website3_Value);
            columnValuePairs.Add("Website4_Type", Website4_Type);
            columnValuePairs.Add("Website4_Value", Website4_Value);
            columnValuePairs.Add("Event1_Type", Event1_Type);
            columnValuePairs.Add("Event1_Value", Event1_Value);
            columnValuePairs.Add("Event2_Type", Event2_Type);
            columnValuePairs.Add("Event2_Value", Event2_Value);
            columnValuePairs.Add("Event3_Type", Event3_Type);
            columnValuePairs.Add("Event3_Value", Event3_Value);
            columnValuePairs.Add("CustomField1_Type", CustomField1_Type);
            columnValuePairs.Add("CustomField1_Value", CustomField1_Value);
            columnValuePairs.Add("CustomField2_Type", CustomField2_Type);
            columnValuePairs.Add("CustomField2_Value", CustomField2_Value);

            return columnValuePairs;
        }

        public bool ListColumnsValueIsNotEmpty(List<string> columnsName)
        {
            int columnCount = columnsName.Count;
            bool allValuesIsNotEmpty = false;

            if (columnsName != null)
            {
                if (columnCount > 0)
                {
                    string[] names = columnsName.ToArray<string>();
                    for (int i = 0; i < columnCount; i++)
                    {
                        string value = this.ColumnValuePairs[names[i]];
                        if (!string.IsNullOrEmpty(value))
                        {
                            allValuesIsNotEmpty = true;
                        }
                    }
                }
            }

            return allValuesIsNotEmpty;
        }


    }

}
