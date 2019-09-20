using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBAL
{
    public class ContactBAL
    {

        //Add

        public void Add(ContactRec c)
        {
            c.ID = ContactDAL.LastId++;

            ContactDAL.contactList.Add(c);

        }

        //Details
        public ContactRec Details(int id)
        {
            return ContactDAL.contactList.Where(x => x.ID == id).Single();
        }

        //Update

        public void Update(ContactRec c)
        {

            var tempRec = ContactDAL.contactList.Where(x => x.ID == c.ID).Single();

            tempRec.ID = c.ID;
            tempRec.firstName = c.firstName;
            tempRec.lastName = c.lastName;
            tempRec.phoneNum = c.phoneNum;
            tempRec.homeNum = c.homeNum;
            tempRec.businessNum = c.businessNum;
            tempRec.address = c.address;
            tempRec.notes = c.notes;

            tempRec.active = c.active;

        }


        //Delete 
        public void Delete(int id)
        {

            //ContactDAL.contactList.Remove(Details(id));

            //set active to false ?

            var tempRec = ContactDAL.contactList.Where(x => x.ID == id).Single();

            tempRec.active = false;
            //not sure if this is  good 

        }

        //GetAll

        public List<ContactRec> GetAll()
        {

            var list1 = ContactDAL.contactList;

            foreach (var c in list1.ToList())
            {

                if (c.phoneNum == null)
                {
                    c.phoneNum = "Not Available";
                }

                if (c.active == false)
                {
                    list1.Remove(c);
                }


            }




            return list1;
        }





    }
}
