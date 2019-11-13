using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using AutoMapper;
using AutoMapper.Mappers;
using System.Globalization;

namespace ContactsPhoneCsvTransform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadCsv_Click(object sender, EventArgs e)
        {

            MapTest();


            // Configure AutoMapper
            var configuration = new MapperConfiguration(cfg =>
              cfg.CreateMap<PhoneContact, PhoneContactGoogle>()
                .ForMember(dest => dest.GivenName, opt => opt.MapFrom(src => src.GivenName))
                .ForMember(dest => dest.AdditionalName, opt => opt.MapFrom(src => src.AdditionalName))
                .ForMember(dest => dest.FamilyName, opt => opt.MapFrom(src => src.FamilyName))
                .ForMember(dest => dest.NameSuffix, opt => opt.MapFrom(src => src.NameSuffix))
                .ForMember(dest => dest.Initials, opt => opt.MapFrom(src => src.Initials))
                .ForMember(dest => dest.Birthday, opt => opt.ConvertUsing(new DateConverter(), src => src.Birthday))
                .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                .ForMember(dest => dest.E_mail3_Value, opt => opt.MapFrom(src =>
                    src.CombineVal(new string[] { "E_mail", "E_mail2" }.ToList())
                ))
                .ForMember(dest => dest.Phone2_Value, opt => opt.MapFrom(src =>
                    src.CombineVal(new string[] { "HomePhone", "HomePhone2" }.ToList())
                ))
                .ForMember(dest => dest.Phone3_Value, opt => opt.MapFrom(src => src.WorkFax))
                .ForMember(dest => dest.Phone4_Value, opt => opt.MapFrom(src =>
                    src.CombineVal(new string[] { "MobilePhone", "RadioPhone" }.ToList())
                ))
                .ForMember(dest => dest.Phone5_Value, opt => opt.MapFrom(src =>
                    src.CombineVal(new string[] { "WorkPhone", "WorkPhone2" }.ToList())
                ))
                .ForMember(dest => dest.Phone6_Value, opt => opt.MapFrom(src =>
                    src.CombineVal(new string[] { "OtherPhone", "CarPhone" }.ToList())
                ))
                .ForMember(dest => dest.Phone9_Value, opt => opt.MapFrom(src => src.HomeFax))
                .ForMember(dest => dest.Address1_Street, opt => opt.MapFrom(src => src.AdrHomeStreet))
                .ForMember(dest => dest.Address1_City, opt => opt.MapFrom(src => src.AdrHomeCity))
                .ForMember(dest => dest.Address1_Region, opt => opt.MapFrom(src => src.AdrHomeRegion))
                .ForMember(dest => dest.Address1_PostalCode, opt => opt.MapFrom(src => src.AdrHomePostalCode))
                .ForMember(dest => dest.Address1_Country, opt => opt.MapFrom(src => src.AdrHomeCountry))
                .ForMember(dest => dest.Address2_Street, opt => opt.MapFrom(src => src.AdrWorkStreet))
                .ForMember(dest => dest.Address2_City, opt => opt.MapFrom(src => src.AdrWorkCity))
                .ForMember(dest => dest.Address2_Region, opt => opt.MapFrom(src => src.AdrWorkRegion))
                .ForMember(dest => dest.Address2_PostalCode, opt => opt.MapFrom(src => src.AdrWorkPostalCode))
                .ForMember(dest => dest.Address2_Country, opt => opt.MapFrom(src => src.AdrWorkCountry))
                .ForMember(dest => dest.Address3_Street, opt => opt.MapFrom(src => src.AdrOtherStreet))
                .ForMember(dest => dest.Address3_City, opt => opt.MapFrom(src => src.AdrOtherCity))
                .ForMember(dest => dest.Address3_Region, opt => opt.MapFrom(src => src.AdrOtherRegion))
                .ForMember(dest => dest.Address3_Country, opt => opt.MapFrom(src => src.AdrOtherCountry))
                .ForMember(dest => dest.Organization1_Name, opt => opt.MapFrom(src => src.OrgName))
                .ForMember(dest => dest.Organization1_Title, opt => opt.MapFrom(src => src.OrgTitle))
                .ForMember(dest => dest.Organization1_Department, opt => opt.MapFrom(src => src.OrgDepartment))
                .ForMember(dest => dest.Relation6_Value, opt => opt.MapFrom(src => src.Spouse))
                .ForMember(dest => dest.Relation7_Value, opt => opt.MapFrom(src => src.Assistant))
                .ForMember(dest => dest.Relation13_Value, opt => opt.MapFrom(src => src.Child))
                .ForMember(dest => dest.Website3_Value, opt => opt.MapFrom(src => src.WebSite))
                .ForMember(dest => dest.Event1_Value, opt => opt.ConvertUsing(new DateConverter(), src => src.Anniversary))
                .AfterMap((src, dest) => dest.GroupMembership = "* myContacts")
                .AfterMap((src, dest) => dest.E_mail3_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "E_mail3_Value" }.ToList()
                                    )? "Другое" : ""
                    )
                .AfterMap((src, dest) => dest.Phone2_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Phone2_Value" }.ToList()
                                    ) ? "Домашние контакты" : ""
                    )
                .AfterMap((src, dest) => dest.Phone3_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Phone3_Value" }.ToList()
                                    ) ? "workFax" : ""
                    )
                .AfterMap((src, dest) => dest.Phone4_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Phone4_Value" }.ToList()
                                    ) ? "Мобильные устройства" : ""
                    )
                .AfterMap((src, dest) => dest.Phone5_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Phone5_Value" }.ToList()
                                    ) ? "Рабочие контакты" : ""
                    )
                .AfterMap((src, dest) => dest.Phone6_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Phone6_Value" }.ToList()
                                    ) ? "Другое" : ""
                    )
                .AfterMap((src, dest) => dest.Phone9_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Phone9_Value" }.ToList()
                                    ) ? "homeFax" : ""
                    )
                .AfterMap((src, dest) => dest.Address1_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Address1_Street",
                                    "Address1_City",
                                    "Address1_POBox",
                                    "Address1_Region",
                                    "Address1_PostalCode",
                                    "Address1_Country",
                                    "Address1_ExtendedAddress"}.ToList()
                                    ) ? "Домашние контакты" : ""
                    )
                .AfterMap((src, dest) => dest.Address2_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Address2_Street",
                                    "Address2_City",
                                    "Address2_POBox",
                                    "Address2_Region",
                                    "Address2_PostalCode",
                                    "Address2_Country",
                                    "Address2_ExtendedAddress"}.ToList()
                                    ) ? "Рабочие контакты" : ""
                    )
                .AfterMap((src, dest) => dest.Address3_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Address3_Street",
                                    "Address3_City",
                                    "Address3_POBox",
                                    "Address3_Region",
                                    "Address3_PostalCode",
                                    "Address3_Country",
                                    "Address3_ExtendedAddress"}.ToList()
                                    ) ? "Other" : ""
                    )
                .AfterMap((src, dest) => dest.Relation6_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Relation6_Value" }.ToList()
                                    ) ? "Spouse" : ""
                    )
                .AfterMap((src, dest) => dest.Relation7_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Relation7_Value" }.ToList()
                                    ) ? "Assistant" : ""
                    )
                .AfterMap((src, dest) => dest.Relation13_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Relation13_Value" }.ToList()
                                    ) ? "Child" : ""
                    )
                .AfterMap((src, dest) => dest.Website3_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Website3_Value" }.ToList()
                                    ) ? "Домашняя страница" : ""
                    )
                .AfterMap((src, dest) => dest.Event1_Type = dest.ListColumnsValueIsNotEmpty(
                    new string[] { "Event1_Value" }.ToList()
                                    ) ? "Anniversary" : ""
                    )

                );

            List<PhoneContactGoogle> phoneContactGoogleList = new List<PhoneContactGoogle>();
            using (var reader = new StreamReader("D:\\BackUP\\Phone_Contacts\\Phone_Contacts_20181217_UTF8.CSV"))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.RegisterClassMap<PhoneContactMapFromCsv>();

                IEnumerable<PhoneContact> records = csv.GetRecords<PhoneContact>();

                foreach (var contact in records)
                {
                    //System.Console.WriteLine(contact.GivenName + " " + contact.AdditionalName + " " + contact.FamilyName);
                    PhoneContactGoogle phoneContactGoogle;
                    phoneContactGoogle = MapPhoneContact(contact, configuration);
                    //System.Console.WriteLine(phoneContactGoogle.GivenName + " "
                    //    + phoneContactGoogle.AdditionalName + " "
                    //    + phoneContactGoogle.FamilyName + " "
                    //    + phoneContactGoogle.E_mail3_Value + " "

                    //    + phoneContactGoogle.Phone2_Value + " "
                    //    + phoneContactGoogle.Phone4_Value + " "
                    //    + phoneContactGoogle.Phone5_Value + " "
                    //    + phoneContactGoogle.Phone6_Value
                    //);
                    phoneContactGoogleList.Add(phoneContactGoogle);

                }

            }



            using (var writer = new StreamWriter("D:\\BackUP\\Phone_Contacts\\Phone_Contacts_20181217_UTF8_GoogleFormat.CSV"))
            using (var csv = new CsvWriter(writer))
            {
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.RegisterClassMap<PhoneContactGoogleMapToCsv>();

                csv.WriteRecords<PhoneContactGoogle>(phoneContactGoogleList);

            }




        }

        public class DateConverter : IValueConverter<string, string>
        {
            public string Convert(string sourceMember, ResolutionContext context)
            {
                DateTime dateTime;

                try
                {
                    dateTime = System.Convert.ToDateTime(sourceMember, new CultureInfo("ru-RU"));
                    string year = dateTime.Year.ToString();
                    string mounth = dateTime.Month.ToString();
                    string day = dateTime.Day.ToString();
                    return year + "-" + mounth + "-" + day;
                }
                catch(FormatException)
                {
                    return string.Empty;
                }

            }
        }

        private PhoneContactGoogle MapPhoneContact(PhoneContact contact, MapperConfiguration configuration)
        {
            // Perform mapping
            Mapper mapper = new Mapper(configuration);
            PhoneContactGoogle phoneContactGoogle = mapper.Map<PhoneContact, PhoneContactGoogle>(contact);

            return phoneContactGoogle;
        }


        private void MapTest()
        {
            
            // Model
            var calendarEvent = new CalendarEvent
            {
                Date = new DateTime(2008, 12, 15, 20, 30, 0),
                Title = "Company Holiday Party"
            };

            // Configure AutoMapper
            var configuration = new MapperConfiguration(cfg =>
              cfg.CreateMap<CalendarEvent, CalendarEventForm>()
                .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.Date.Date))
                .ForMember(dest => dest.EventHour, opt => opt.MapFrom(src => src.Date.Hour))
                .ForMember(dest => dest.EventMinute, opt => opt.MapFrom(src => src.Date.Minute)));

            // Perform mapping
            Mapper mapper = new Mapper(configuration);
            CalendarEventForm form = mapper.Map<CalendarEvent, CalendarEventForm>(calendarEvent);

            //form.EventDate.ShouldEqual(new DateTime(2008, 12, 15));
            //form.EventHour.ShouldEqual(20);
            //form.EventMinute.ShouldEqual(30);
            //form.Title.ShouldEqual("Company Holiday Party");
        }
    }

    public class CalendarEvent
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
    }

    public class CalendarEventForm
    {
        public DateTime EventDate { get; set; }
        public int EventHour { get; set; }
        public int EventMinute { get; set; }
        public string Title { get; set; }
    }



}
