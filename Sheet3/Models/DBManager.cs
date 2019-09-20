using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sheet3.Models
{
    public class DBManager
    {
        ContactBAL.ContactBAL bll = new ContactBAL.ContactBAL();

        /// <summary>
        /// Adds a new password record.
        /// </summary>
        /// <param name="p">The password object.</param>
        public void Add(ContactRec c)
        {
            bll.Add(c);

        }

        public List<ContactRec> GetAll()
        {
            return bll.GetAll();

        }

        public void Delete(int id)
        {

            bll.Delete(id);

        }


        public ContactRec Details(int id)
        {
            return bll.Details(id);

        }

        public void Update(ContactRec c)
        {

            bll.Update(c);


        }
    }
}