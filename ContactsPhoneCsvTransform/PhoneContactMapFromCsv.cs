using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactsPhoneCsvTransform
{
    public sealed class PhoneContactMapFromCsv : ClassMap<PhoneContact>
    {
        public PhoneContactMapFromCsv()
        {

            Map(m => m.GivenName).Name("Имя");
            Map(m => m.AdditionalName).Name("Отчество");
            Map(m => m.FamilyName).Name("Фамилия");
            Map(m => m.NameSuffix).Name("Суффикс");
            Map(m => m.OrgName).Name("Организация");
            Map(m => m.OrgDepartment).Name("Отдел");
            Map(m => m.OrgTitle).Name("Должность");
            Map(m => m.AdrWorkStreet).Name("Улица (раб. адрес)");
            Map(m => m.AdrWorkStreetExt).Name("Улица 2 (раб. адрес)");
            Map(m => m.AdrWorkCity).Name("Город (раб. адрес)");
            Map(m => m.AdrWorkRegion).Name("Область (раб. адрес)");
            Map(m => m.AdrWorkPostalCode).Name("Индекс (раб. адрес)");
            Map(m => m.AdrWorkCountry).Name("Страна (раб. адрес)");
            Map(m => m.AdrHomeStreet).Name("Улица (дом. адрес)");
            Map(m => m.AdrHomeStreetExt).Name("Улица 2 (дом. адрес) ");
            Map(m => m.AdrHomeCity).Name("Город (дом. адрес)");
            Map(m => m.AdrHomeRegion).Name("Область (дом. адрес)");
            Map(m => m.AdrHomePostalCode).Name("Почтовый код (дом.)");
            Map(m => m.AdrHomeCountry).Name("Страна (дом. адрес)");
            Map(m => m.AdrOtherStreet).Name("Улица (другой адрес)");
            Map(m => m.AdrOtherStreetExt).Name("Улица  2 (другой адрес)");
            Map(m => m.AdrOtherCity).Name("Город  (другой адрес)");
            Map(m => m.AdrOtherRegion).Name("Область  (другой адрес)");
            Map(m => m.AdrOtherPostalCode).Name("Индекс  (другой адрес)");
            Map(m => m.AdrOtherCountry).Name("Страна  (другой адрес)");
            Map(m => m.WorkFax).Name("Рабочий факс");
            Map(m => m.WorkPhone).Name("Рабочий телефон");
            Map(m => m.WorkPhone2).Name("Телефон раб. 2");
            Map(m => m.CarPhone).Name("Телефон в машине");
            Map(m => m.HomeFax).Name("Домашний факс");
            Map(m => m.HomePhone).Name("Домашний телефон");
            Map(m => m.HomePhone2).Name("Телефон дом. 2");
            Map(m => m.MobilePhone).Name("Телефон переносной");
            Map(m => m.OtherPhone).Name("Другой телефон");
            Map(m => m.Pager).Name("Пейджер");
            Map(m => m.MainPhone).Name("Основной телефон");
            Map(m => m.RadioPhone).Name("Радиотелефон");
            Map(m => m.WebSite).Name("Веб-страница");
            Map(m => m.Anniversary).Name("Годовщина");
            Map(m => m.Birthday).Name("День рождения");
            Map(m => m.Child).Name("Дети");
            Map(m => m.Notes).Name("Заметки");
            Map(m => m.Assistant).Name("Имя помощника");
            Map(m => m.Initials).Name("Инициалы");
            Map(m => m.Spouse).Name("Супруг(а)");
            Map(m => m.E_mail).Name("Адрес эл. почты");
            Map(m => m.E_mail2).Name("Адрес 2 эл. почты");

        }
    }

}
