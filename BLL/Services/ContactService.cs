using BLL.Dto;
using DAL.DataBase;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ContactService
    {
        DataBaseContext context = new DataBaseContext();

        public List<ContactListDto> GetContactLists()
        {
            var contacts = context.Contacts.Select(c => new ContactListDto
            {
                Id = c.Id,
                FullName = $"{c.Name} {c.LastName}",
                PhoneNumber = c.PhoneNumber,
            }).ToList();
            return contacts;
        }

        public List<ContactListDto> SearchContact(string searchKey)
        {
            var contactQuery = context.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                contactQuery = contactQuery.Where(c =>
                      c.Name.Contains(searchKey)
                   || c.LastName.Contains(searchKey)
                   || c.PhoneNumber.Contains(searchKey)
                   || c.Company.Contains(searchKey)
                );
            }

            var data = contactQuery.Select(c => new ContactListDto
            {
                Id = c.Id,
                FullName = $"{c.Name} {c.LastName}",
                PhoneNumber = c.PhoneNumber
            }).ToList();

            return data;
        }

        public ResultDto DeleteContact(int id)
        {
            var contact = context.Contacts.Find(id);
            if (contact != null)
            {
                context.Contacts.Remove(contact);
                context.SaveChanges();
                return new ResultDto 
                {
                    IsSuccess = true,
                    message = "مخاطب با موفقیت حذف شد."
                };
            }
            return new ResultDto
            {
                IsSuccess = false,
                message = "مخاطب یافت نشد."
            };
        }
    }
}
