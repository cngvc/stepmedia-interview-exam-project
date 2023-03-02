using EmployeeManagement.Models;

namespace EmployeeManagement.Data
{
    public class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Managers.Any())
            {
                Console.WriteLine("--> Seeding data");

                context.Managers.AddRange(
                    new Manager()
                    {
                        FullName = "Shawn G. Hinton",
                        Staffs = new List<Staff>()
                        {
                            new Staff {
                                FullName = "Kevin J. Jones",
                                DOB = new DateTime(2000, 1, 1)
                            },
                            new Staff {
                                FullName = "Kathleen M. Wilson",
                                DOB = new DateTime(1992, 1, 1)
                            },
                            new Staff {
                                FullName = "Paul T. Brewer",
                                DOB = new DateTime(1980, 1, 1)
                            }
                        },
                    }, new Manager()
                    {
                        FullName = "An Marilyn M. White",
                        Staffs = new List<Staff>()
                        {
                            new Staff {
                                FullName = "Vincent R. Chamness",
                                DOB = new DateTime(1999, 1, 1)
                            },
                            new Staff {
                                FullName = "Teresa V. Feliciano",
                                DOB = new DateTime(2001, 1, 1)
                            },
                            new Staff {
                                FullName = "Josh L. Williams",
                                DOB = new DateTime(1969, 1, 1)
                            }
                        },

                    }, new Manager()
                    {
                        FullName = "Ralph N. Clarke",
                        Staffs = new List<Staff>()
                        {
                            new Staff {
                                FullName = "Rachael L. Novotny",
                                DOB = new DateTime(1980, 1, 1)
                            },
                            new Staff {
                                FullName = "Maria R. Holder",
                                DOB = new DateTime(1978, 1, 1)
                            },
                            new Staff {
                                FullName = "Ginger W. Case",
                                DOB = new DateTime(1992, 1, 1)
                            }
                        },

                    }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}