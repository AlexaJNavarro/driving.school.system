using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA.Models;
using DATA.Helper;

namespace DATA
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.District();
            Program.User();
            Program.Type();
            Program.Package();
            Program.UserPackage();
        }
        static void UserPackage()
        {
            using (var db = new DBDrivingSchoolEntities())
            {
                var models = new List<user_package>()
                {
                    new user_package()
                    {
                        id_user = 1, id_package = 3,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new user_package()
                    {
                        id_user = 2, id_package = 2,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new user_package()
                    {
                        id_user = 4, id_package = 3,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new user_package()
                    {
                        id_user = 3, id_package = 3,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                };
                foreach (var model in models)
                {
                    db.user_package.Add(model);
                    db.SaveChanges();
                }
            }
        }
        
        static void Package()
        {
            using (var db = new DBDrivingSchoolEntities())
            {
                var models = new List<package>() { 
                    new package(){
                        theory_test = false, practical_test = true, driving_hours = 5,
                        description = "esta es la descripción del paquete A",
                        id_type = 1, price = 100f,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new package(){
                        theory_test = true, practical_test = false, driving_hours = 8,
                        description = "esta es la descripción del paquete B",
                        id_type = 2, price = 150f,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new package(){
                        theory_test = true, practical_test = true, driving_hours = 10,
                        description = "esta es la descripción del paquete C",
                        id_type = 3, price = 220.50f,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new package(){
                        theory_test = true, practical_test = true, driving_hours = 15,
                        description = "esta es la descripción del paquete D",
                        id_type = 4, price = 800f,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                };
                foreach (var model in models)
                {
                    db.package.Add(model);
                    db.SaveChanges();
                }
            }
        }

                static void Type()
        {
            using (var db = new DBDrivingSchoolEntities())
            {
                var models = new List<type>()
                {
                    new type(){name = "A",created_at = DateTime.Now, updated_at = DateTime.Now },
                    new type(){name = "B",created_at = DateTime.Now, updated_at = DateTime.Now },
                    new type(){name = "C",created_at = DateTime.Now, updated_at = DateTime.Now },
                    new type(){name = "D",created_at = DateTime.Now, updated_at = DateTime.Now },
                };
                foreach (var model in models)
                {
                    db.type.Add(model);
                    db.SaveChanges();
                }
            }
        }

        static void User()
        {
            using (var db = new DBDrivingSchoolEntities())
            {
                var models = new List<Models.users>(){
                    new users { 
                        nombres = "Leonardo", 
                        apellido_paterno = "Nolasco", apellido_materno = "Leyva",
                        email = "leo@gmail.com", password = Encrypt.GetSHA256("12345678"),
                        id_district = 3,
                        created_at = DateTime.Now, updated_at = DateTime.Now 
                    },
                    new users {
                        nombres = "Antonio",
                        apellido_paterno = "Nolasco", apellido_materno = "Leyva",
                        email = "Antonio@gmail.com", password = Encrypt.GetSHA256("12345678"),
                        id_district = 2,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new users {
                        nombres = "Juan",
                        apellido_paterno = "Nolasco", apellido_materno = "Leyva",
                        email = "Juan@gmail.com", password = Encrypt.GetSHA256("12345678"),
                        id_district = 2,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                    new users {
                        nombres = "Alexandra Jaqueline",
                        apellido_paterno = "Navarro", apellido_materno = "Navarro",
                        email = "Alexandra@gmail.com", password = Encrypt.GetSHA256("12345678"),
                        id_district = 3,
                        created_at = DateTime.Now, updated_at = DateTime.Now
                    },
                };
                foreach (var model in models)
                {
                    db.users.Add(model);
                    db.SaveChanges();
                }
            }
        }

        static void District()
        {
            using (var db = new DBDrivingSchoolEntities())
            {
                var models = new List<Models.district>(){
                    new district { name = "SJM", created_at = DateTime.Now, updated_at = DateTime.Now },
                    new district { name = "Chorrillos", created_at = DateTime.Now, updated_at = DateTime.Now },
                    new district { name = "Barranco", created_at = DateTime.Now, updated_at = DateTime.Now },
                };
                foreach (var model in models)
                {
                    db.district.Add(model);
                    db.SaveChanges();
                }
            }
        }
    }
}
