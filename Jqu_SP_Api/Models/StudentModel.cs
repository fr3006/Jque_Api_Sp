using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jqu_SP_Api.Models
{
    public class StudentModel : ApiController
    {
        private Models.studentDBEntities db = new Models.studentDBEntities();
        // GET: api/Student
        public IEnumerable<USP_Student_Select_all_Result> GetPersona()
        {

           var courses = db.USP_Student_Select_all().ToList();

            return courses;                 
                        
        }
   
        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
