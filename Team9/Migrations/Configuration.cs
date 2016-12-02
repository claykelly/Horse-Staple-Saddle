namespace Team9.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Team9.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Team9.Models.AppDbContext db)
        {

            //Create a user manager to add users to databases
            UserManager<AppUser> userManager = new UserManager<AppUser>(new UserStore<AppUser>(db));

            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 5,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };
            //create a role manager
            AppRoleManager roleManager = new AppRoleManager(new RoleStore<AppRole>(db));

            //create a admin role
            String roleName0 = "Admin";
            //check to see if the role exists
            if (roleManager.RoleExists(roleName0) == false) //role doesn't exist
            {
                roleManager.Create(new AppRole(roleName0));
            }

            //create a user
            String strEmail99 = "admin@example.com";
            AppUser user99 = new AppUser()
            {
                UserName = strEmail99,
                Email = strEmail99,
                City = "Austin",
                PhoneNumber = "(512)555-1234",
                StreeAddress = "123 Main Street",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd00 = userManager.FindByName(strEmail99);
            if (userToAdd00 == null) //this user doesn't exist anymore
            {
                userManager.Create(user99, "password");
                userToAdd00 = userManager.FindByName(strEmail99);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd00.Id, roleName0) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd00.Id, roleName0);
            }

            //create a customer role
            String roleName1 = "Customer";
            //check to see if the role exists
            if (roleManager.RoleExists(roleName1) == false) //role doesn't exist
            {
                roleManager.Create(new AppRole(roleName1));
            }

            //create a user
            String strEmail0 = "cbaker@freezing.co.uk";
            AppUser user0 = new AppUser()
            {
                
                FName = "Christopher",
                LName = "Baker",
                UserName = strEmail0,
                Email = strEmail0,
                City = "Austin",
                PhoneNumber = "5125571146",
                StreeAddress = "1245 Lake Austin Blvd.",
                State = "TX",
                Zip = "78733"
            };
            //see if the user is already there
            AppUser userToAdd0 = userManager.FindByName(strEmail0);
            if (userToAdd0 == null) //this user doesn't exist anymore
            {
                userManager.Create(user0, "hello");
                userToAdd0 = userManager.FindByName(strEmail0);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd0.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd0.Id, roleName1);
            }
            //create a user
            String strEmail1 = "mb@aool.com";
            AppUser user1 = new AppUser()
            {
                
                FName = "Michelle",
                LName = "Banks",
                UserName = strEmail1,
                Email = strEmail1,
                City = "San Antonio",
                PhoneNumber = "2102678873",
                StreeAddress = "1300 Tall Pine Lane",
                State = "TX",
                Zip = "78261"
            };
            //see if the user is already there
            AppUser userToAdd1 = userManager.FindByName(strEmail1);
            if (userToAdd1 == null) //this user doesn't exist anymore
            {
                userManager.Create(user1, "555555");
                userToAdd1 = userManager.FindByName(strEmail1);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd1.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd1.Id, roleName1);
            }
            //create a user
            String strEmail2 = "fd@aool.com";
            AppUser user2 = new AppUser()
            {
                
                FName = "Franco",
                LName = "Broccolo",
                UserName = strEmail2,
                Email = strEmail2,
                City = "Houston",
                PhoneNumber = "8175659699",
                StreeAddress = "62 Browning Rd",
                State = "TX",
                Zip = "77019"
            };
            //see if the user is already there
            AppUser userToAdd2 = userManager.FindByName(strEmail2);
            if (userToAdd2 == null) //this user doesn't exist anymore
            {
                userManager.Create(user2, "666666");
                userToAdd2 = userManager.FindByName(strEmail2);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd2.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd2.Id, roleName1);
            }
            //create a user
            String strEmail3 = "wendy@ggmail.com";
            AppUser user3 = new AppUser()
            {
               
                FName = "Wendy",
                LName = "Chang",
                UserName = strEmail3,
                Email = strEmail3,
                City = "Austin",
                PhoneNumber = "5125943222",
                StreeAddress = "202 Bellmont Hall",
                State = "TX",
                Zip = "78713"
            };
            //see if the user is already there
            AppUser userToAdd3 = userManager.FindByName(strEmail3);
            if (userToAdd3 == null) //this user doesn't exist anymore
            {
                userManager.Create(user3, "texas");
                userToAdd3 = userManager.FindByName(strEmail3);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd3.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd3.Id, roleName1);
            }
            //create a user
            String strEmail4 = "limchou@yaho.com";
            AppUser user4 = new AppUser()
            {
                
                FName = "Lim",
                LName = "Chou",
                UserName = strEmail4,
                Email = strEmail4,
                City = "San Antonio",
                PhoneNumber = "2107724599",
                StreeAddress = "1600 Teresa Lane",
                State = "TX",
                Zip = "78266"
            };
            //see if the user is already there
            AppUser userToAdd4 = userManager.FindByName(strEmail4);
            if (userToAdd4 == null) //this user doesn't exist anymore
            {
                userManager.Create(user4, "austin");
                userToAdd4 = userManager.FindByName(strEmail4);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd4.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd4.Id, roleName1);
            }
            //create a user
            String strEmail5 = "11111111.Dixon@aool.com";
            AppUser user5 = new AppUser()
            {
                
                FName = "Shan",
                LName = "Dixon",
                UserName = strEmail5,
                Email = strEmail5,
                City = "Dallas",
                PhoneNumber = "2142643255",
                StreeAddress = "234 Holston Circle",
                State = "TX",
                Zip = "75208"
            };
            //see if the user is already there
            AppUser userToAdd5 = userManager.FindByName(strEmail5);
            if (userToAdd5 == null) //this user doesn't exist anymore
            {
                userManager.Create(user5, "11111111");
                userToAdd5 = userManager.FindByName(strEmail5);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd5.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd5.Id, roleName1);
            }
            //create a user
            String strEmail6 = "louann@ggmail.com";
            AppUser user6 = new AppUser()
            {
                
                FName = "Lou Ann",
                LName = "Feeley",
                UserName = strEmail6,
                Email = strEmail6,
                City = "Houston",
                PhoneNumber = "8172556749",
                StreeAddress = "600 S 8th Street W",
                State = "TX",
                Zip = "77010"
            };
            //see if the user is already there
            AppUser userToAdd6 = userManager.FindByName(strEmail6);
            if (userToAdd6 == null) //this user doesn't exist anymore
            {
                userManager.Create(user6, "aggies");
                userToAdd6 = userManager.FindByName(strEmail6);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd6.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd6.Id, roleName1);
            }
            //create a user
            String strEmail7 = "tfreeley@minntonka.ci.state.mn.us";
            AppUser user7 = new AppUser()
            {
                
                FName = "Tesa",
                LName = "Freeley",
                UserName = strEmail7,
                Email = strEmail7,
                City = "Houston",
                PhoneNumber = "8173255687",
                StreeAddress = "4448 Fairview Ave.",
                State = "TX",
                Zip = "77009"
            };
            //see if the user is already there
            AppUser userToAdd7 = userManager.FindByName(strEmail7);
            if (userToAdd7 == null) //this user doesn't exist anymore
            {
                userManager.Create(user7, "raiders");
                userToAdd7 = userManager.FindByName(strEmail7);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd7.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd7.Id, roleName1);
            }
            //create a user
            String strEmail8 = "mgar@aool.com";
            AppUser user8 = new AppUser()
            {
                
                FName = "Margaret",
                LName = "Garcia",
                UserName = strEmail8,
                Email = strEmail8,
                City = "Houston",
                PhoneNumber = "8176593544",
                StreeAddress = "594 Longview",
                State = "TX",
                Zip = "77003"
            };
            //see if the user is already there
            AppUser userToAdd8 = userManager.FindByName(strEmail8);
            if (userToAdd8 == null) //this user doesn't exist anymore
            {
                userManager.Create(user8, "mustangs");
                userToAdd8 = userManager.FindByName(strEmail8);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd8.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd8.Id, roleName1);
            }
            //create a user
            String strEmail9 = "chaley@thug.com";
            AppUser user9 = new AppUser()
            {
                
                FName = "Charles",
                LName = "Haley",
                UserName = strEmail9,
                Email = strEmail9,
                City = "Dallas",
                PhoneNumber = "2148475583",
                StreeAddress = "One Cowboy Pkwy",
                State = "TX",
                Zip = "75261"
            };
            //see if the user is already there
            AppUser userToAdd9 = userManager.FindByName(strEmail9);
            if (userToAdd9 == null) //this user doesn't exist anymore
            {
                userManager.Create(user9, "mydog");
                userToAdd9 = userManager.FindByName(strEmail9);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd9.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd9.Id, roleName1);
            }
            //create a user
            String strEmail10 = "jeff@ggmail.com";
            AppUser user10 = new AppUser()
            {
                
                FName = "Jeffrey",
                LName = "Hampton",
                UserName = strEmail10,
                Email = strEmail10,
                City = "Austin",
                PhoneNumber = "5126978613",
                StreeAddress = "337 38th St.",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd10 = userManager.FindByName(strEmail10);
            if (userToAdd10 == null) //this user doesn't exist anymore
            {
                userManager.Create(user10, "jeffh");
                userToAdd10 = userManager.FindByName(strEmail10);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd10.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd10.Id, roleName1);
            }
            //create a user
            String strEmail11 = "wjhearniii@umch.edu";
            AppUser user11 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5497163903436520" },
                
                FName = "John",
                LName = "Hearn",
                UserName = strEmail11,
                Email = strEmail11,
                City = "Dallas",
                PhoneNumber = "2148965621",
                StreeAddress = "4225 North First",
                State = "TX",
                Zip = "75237"
            };
            //see if the user is already there
            AppUser userToAdd11 = userManager.FindByName(strEmail11);
            if (userToAdd11 == null) //this user doesn't exist anymore
            {
                userManager.Create(user11, "logicon");
                userToAdd11 = userManager.FindByName(strEmail11);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd11.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd11.Id, roleName1);
            }
            //create a user
            String strEmail12 = "hicks43@ggmail.com";
            AppUser user12 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4868476042647310" },
                
                FName = "Anthony",
                LName = "Hicks",
                UserName = strEmail12,
                Email = strEmail12,
                City = "San Antonio",
                PhoneNumber = "2105788965",
                StreeAddress = "32 NE Garden Ln., Ste 910",
                State = "TX",
                Zip = "78239"
            };
            //see if the user is already there
            AppUser userToAdd12 = userManager.FindByName(strEmail12);
            if (userToAdd12 == null) //this user doesn't exist anymore
            {
                userManager.Create(user12, "doofus");
                userToAdd12 = userManager.FindByName(strEmail12);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd12.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd12.Id, roleName1);
            }
            //create a user
            String strEmail13 = "bradsingram@mall.utexas.edu";
            AppUser user13 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6727398982004160" },
                
                FName = "Brad",
                LName = "Ingram",
                UserName = strEmail13,
                Email = strEmail13,
                City = "Austin",
                PhoneNumber = "5124678821",
                StreeAddress = "6548 La Posada Ct.",
                State = "TX",
                Zip = "78736"
            };
            //see if the user is already there
            AppUser userToAdd13 = userManager.FindByName(strEmail13);
            if (userToAdd13 == null) //this user doesn't exist anymore
            {
                userManager.Create(user13, "mother");
                userToAdd13 = userManager.FindByName(strEmail13);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd13.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd13.Id, roleName1);
            }
            //create a user
            String strEmail14 = "mother.Ingram@aool.com";
            AppUser user14 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "545497452517418" },
                
                FName = "Todd",
                LName = "Jacobs",
                UserName = strEmail14,
                Email = strEmail14,
                City = "Austin",
                PhoneNumber = "5124653365",
                StreeAddress = "4564 Elm St.",
                State = "TX",
                Zip = "78731"
            };
            //see if the user is already there
            AppUser userToAdd14 = userManager.FindByName(strEmail14);
            if (userToAdd14 == null) //this user doesn't exist anymore
            {
                userManager.Create(user14, "12345");
                userToAdd14 = userManager.FindByName(strEmail14);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd14.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd14.Id, roleName1);
            }
            //create a user
            String strEmail15 = "victoria@aool.com";
            AppUser user15 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5414364986244200" },
                
                FName = "Victoria",
                LName = "Lawrence",
                UserName = strEmail15,
                Email = strEmail15,
                City = "Austin",
                PhoneNumber = "5129457399",
                StreeAddress = "6639 Butterfly Ln.",
                State = "TX",
                Zip = "78761"
            };
            //see if the user is already there
            AppUser userToAdd15 = userManager.FindByName(strEmail15);
            if (userToAdd15 == null) //this user doesn't exist anymore
            {
                userManager.Create(user15, "nothing");
                userToAdd15 = userManager.FindByName(strEmail15);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd15.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd15.Id, roleName1);
            }
            //create a user
            String strEmail16 = "lineback@flush.net";
            AppUser user16 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4093643507872300" },
                
                FName = "Erik",
                LName = "Lineback",
                UserName = strEmail16,
                Email = strEmail16,
                City = "San Antonio",
                PhoneNumber = "2102449976",
                StreeAddress = "1300 Netherland St",
                State = "TX",
                Zip = "78293"
            };
            //see if the user is already there
            AppUser userToAdd16 = userManager.FindByName(strEmail16);
            if (userToAdd16 == null) //this user doesn't exist anymore
            {
                userManager.Create(user16, "GoodFellow");
                userToAdd16 = userManager.FindByName(strEmail16);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd16.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd16.Id, roleName1);
            }
            //create a user
            String strEmail17 = "elowe@netscrape.net";
            AppUser user17 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "877527552236339" },
                
                FName = "Ernest",
                LName = "Lowe",
                UserName = strEmail17,
                Email = strEmail17,
                City = "San Antonio",
                PhoneNumber = "2105344627",
                StreeAddress = "3201 Pine Drive",
                State = "TX",
                Zip = "78279"
            };
            //see if the user is already there
            AppUser userToAdd17 = userManager.FindByName(strEmail17);
            if (userToAdd17 == null) //this user doesn't exist anymore
            {
                userManager.Create(user17, "Elbow");
                userToAdd17 = userManager.FindByName(strEmail17);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd17.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd17.Id, roleName1);
            }
            //create a user
            String strEmail18 = "luce_chuck@ggmail.com";
            AppUser user18 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5451814661069320" },
                
                FName = "Chuck",
                LName = "Luce",
                UserName = strEmail18,
                Email = strEmail18,
                City = "San Antonio",
                PhoneNumber = "2106983548",
                StreeAddress = "2345 Rolling Clouds",
                State = "TX",
                Zip = "78268"
            };
            //see if the user is already there
            AppUser userToAdd18 = userManager.FindByName(strEmail18);
            if (userToAdd18 == null) //this user doesn't exist anymore
            {
                userManager.Create(user18, "LuceyDucey");
                userToAdd18 = userManager.FindByName(strEmail18);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd18.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd18.Id, roleName1);
            }
            //create a user
            String strEmail19 = "mackcloud@pimpdaddy.com";
            AppUser user19 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4355077062414870" },
                
                FName = "Jennifer",
                LName = "MacLeod",
                UserName = strEmail19,
                Email = strEmail19,
                City = "Austin",
                PhoneNumber = "5124748138",
                StreeAddress = "2504 Far West Blvd.",
                State = "TX",
                Zip = "78731"
            };
            //see if the user is already there
            AppUser userToAdd19 = userManager.FindByName(strEmail19);
            if (userToAdd19 == null) //this user doesn't exist anymore
            {
                userManager.Create(user19, "cloudyday");
                userToAdd19 = userManager.FindByName(strEmail19);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd19.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd19.Id, roleName1);
            }
            //create a user
            String strEmail20 = "liz@ggmail.com";
            AppUser user20 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4241928871243970" },
                
                FName = "Elizabeth",
                LName = "Markham",
                UserName = strEmail20,
                Email = strEmail20,
                City = "Austin",
                PhoneNumber = "5124579845",
                StreeAddress = "7861 Chevy Chase",
                State = "TX",
                Zip = "78732"
            };
            //see if the user is already there
            AppUser userToAdd20 = userManager.FindByName(strEmail20);
            if (userToAdd20 == null) //this user doesn't exist anymore
            {
                userManager.Create(user20, "emarkbark");
                userToAdd20 = userManager.FindByName(strEmail20);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd20.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd20.Id, roleName1);
            }
            //create a user
            String strEmail21 = "mclarence@aool.com";
            AppUser user21 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6310804739616290" },
                
                FName = "Clarence",
                LName = "Martin",
                UserName = strEmail21,
                Email = strEmail21,
                City = "Houston",
                PhoneNumber = "8174955201",
                StreeAddress = "87 Alcedo St.",
                State = "TX",
                Zip = "77045"
            };
            //see if the user is already there
            AppUser userToAdd21 = userManager.FindByName(strEmail21);
            if (userToAdd21 == null) //this user doesn't exist anymore
            {
                userManager.Create(user21, "smartinmartin");
                userToAdd21 = userManager.FindByName(strEmail21);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd21.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd21.Id, roleName1);
            }
            //create a user
            String strEmail22 = "smartinmartin.Martin@aool.com";
            AppUser user22 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "782806865061369" },
                
                FName = "Gregory",
                LName = "Martinez",
                UserName = strEmail22,
                Email = strEmail22,
                City = "Houston",
                PhoneNumber = "8178746718",
                StreeAddress = "8295 Sunset Blvd.",
                State = "TX",
                Zip = "77030"
            };
            //see if the user is already there
            AppUser userToAdd22 = userManager.FindByName(strEmail22);
            if (userToAdd22 == null) //this user doesn't exist anymore
            {
                userManager.Create(user22, "grego");
                userToAdd22 = userManager.FindByName(strEmail22);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd22.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd22.Id, roleName1);
            }
            //create a user
            String strEmail23 = "cmiller@mapster.com";
            AppUser user23 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5458965973058220" },
                
                FName = "Charles",
                LName = "Miller",
                UserName = strEmail23,
                Email = strEmail23,
                City = "Houston",
                PhoneNumber = "8177458615",
                StreeAddress = "8962 Main St.",
                State = "TX",
                Zip = "77031"
            };
            //see if the user is already there
            AppUser userToAdd23 = userManager.FindByName(strEmail23);
            if (userToAdd23 == null) //this user doesn't exist anymore
            {
                userManager.Create(user23, "chucky33");
                userToAdd23 = userManager.FindByName(strEmail23);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd23.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd23.Id, roleName1);
            }
            //create a user
            String strEmail24 = "nelson.Kelly@aool.com";
            AppUser user24 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6420363774166000" },
                
                FName = "Kelly",
                LName = "Nelson",
                UserName = strEmail24,
                Email = strEmail24,
                City = "Austin",
                PhoneNumber = "5122926966",
                StreeAddress = "2601 Red River",
                State = "TX",
                Zip = "78703"
            };
            //see if the user is already there
            AppUser userToAdd24 = userManager.FindByName(strEmail24);
            if (userToAdd24 == null) //this user doesn't exist anymore
            {
                userManager.Create(user24, "kn1010");
                userToAdd24 = userManager.FindByName(strEmail24);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd24.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd24.Id, roleName1);
            }
            //create a user
            String strEmail25 = "jojoe@ggmail.com";
            AppUser user25 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "697656089924839" },
                
                FName = "Joe",
                LName = "Nguyen",
                UserName = strEmail25,
                Email = strEmail25,
                City = "Dallas",
                PhoneNumber = "2143125897",
                StreeAddress = "1249 4th SW St.",
                State = "TX",
                Zip = "75238"
            };
            //see if the user is already there
            AppUser userToAdd25 = userManager.FindByName(strEmail25);
            if (userToAdd25 == null) //this user doesn't exist anymore
            {
                userManager.Create(user25, "984365dfiop6");
                userToAdd25 = userManager.FindByName(strEmail25);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd25.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd25.Id, roleName1);
            }
            //create a user
            String strEmail26 = "orielly@foxnets.com";
            AppUser user26 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5478875163529160" },
                
                FName = "Bill",
                LName = "O'Reilly",
                UserName = strEmail26,
                Email = strEmail26,
                City = "San Antonio",
                PhoneNumber = "2103450925",
                StreeAddress = "8800 Gringo Drive",
                State = "TX",
                Zip = "78260"
            };
            //see if the user is already there
            AppUser userToAdd26 = userManager.FindByName(strEmail26);
            if (userToAdd26 == null) //this user doesn't exist anymore
            {
                userManager.Create(user26, "billyboy");
                userToAdd26 = userManager.FindByName(strEmail26);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd26.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd26.Id, roleName1);
            }
            //create a user
            String strEmail27 = "or@aool.com";
            AppUser user27 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4156646384501590" },
                
                FName = "Anka",
                LName = "Radkovich",
                UserName = strEmail27,
                Email = strEmail27,
                City = "Dallas",
                PhoneNumber = "2142345566",
                StreeAddress = "1300 Elliott Pl",
                State = "TX",
                Zip = "75260"
            };
            //see if the user is already there
            AppUser userToAdd27 = userManager.FindByName(strEmail27);
            if (userToAdd27 == null) //this user doesn't exist anymore
            {
                userManager.Create(user27, "radicalone");
                userToAdd27 = userManager.FindByName(strEmail27);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd27.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd27.Id, roleName1);
            }
            //create a user
            String strEmail28 = "megrhodes@freezing.co.uk";
            AppUser user28 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6942941089010230" },
                
                FName = "Megan",
                LName = "Rhodes",
                UserName = strEmail28,
                Email = strEmail28,
                City = "Austin",
                PhoneNumber = "5123744746",
                StreeAddress = "4587 Enfield Rd.",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd28 = userManager.FindByName(strEmail28);
            if (userToAdd28 == null) //this user doesn't exist anymore
            {
                userManager.Create(user28, "gohorns");
                userToAdd28 = userManager.FindByName(strEmail28);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd28.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd28.Id, roleName1);
            }
            //create a user
            String strEmail29 = "erynrice@aool.com";
            AppUser user29 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "915495411577097" },
                
                FName = "Eryn",
                LName = "Rice",
                UserName = strEmail29,
                Email = strEmail29,
                City = "Austin",
                PhoneNumber = "5123876657",
                StreeAddress = "3405 Rio Grande",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd29 = userManager.FindByName(strEmail29);
            if (userToAdd29 == null) //this user doesn't exist anymore
            {
                userManager.Create(user29, "iloveme");
                userToAdd29 = userManager.FindByName(strEmail29);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd29.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd29.Id, roleName1);
            }
            //create a user
            String strEmail30 = "jorge@hootmail.com";
            AppUser user30 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5469847618467190" },
                
                FName = "Jorge",
                LName = "Rodriguez",
                UserName = strEmail30,
                Email = strEmail30,
                City = "Houston",
                PhoneNumber = "8178904374",
                StreeAddress = "6788 Cotter Street",
                State = "TX",
                Zip = "77057"
            };
            //see if the user is already there
            AppUser userToAdd30 = userManager.FindByName(strEmail30);
            if (userToAdd30 == null) //this user doesn't exist anymore
            {
                userManager.Create(user30, "454545");
                userToAdd30 = userManager.FindByName(strEmail30);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd30.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd30.Id, roleName1);
            }
            //create a user
            String strEmail31 = "ra@aoo.com";
            AppUser user31 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4906094629756390" },
                
                FName = "Allen",
                LName = "Rogers",
                UserName = strEmail31,
                Email = strEmail31,
                City = "Austin",
                PhoneNumber = "5128752943",
                StreeAddress = "4965 Oak Hill",
                State = "TX",
                Zip = "78732"
            };
            //see if the user is already there
            AppUser userToAdd31 = userManager.FindByName(strEmail31);
            if (userToAdd31 == null) //this user doesn't exist anymore
            {
                userManager.Create(user31, "hpoi8t244");
                userToAdd31 = userManager.FindByName(strEmail31);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd31.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd31.Id, roleName1);
            }
            //create a user
            String strEmail32 = "o_stjean@home.com";
            AppUser user32 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6857413205443210" },
                
                FName = "Olivier",
                LName = "Saint-Jean",
                UserName = strEmail32,
                Email = strEmail32,
                City = "San Antonio",
                PhoneNumber = "2104145678",
                StreeAddress = "255 Toncray Dr.",
                State = "TX",
                Zip = "78292"
            };
            //see if the user is already there
            AppUser userToAdd32 = userManager.FindByName(strEmail32);
            if (userToAdd32 == null) //this user doesn't exist anymore
            {
                userManager.Create(user32, "vb235843");
                userToAdd32 = userManager.FindByName(strEmail32);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd32.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd32.Id, roleName1);
            }
            //create a user
            String strEmail33 = "ss34@ggmail.com";
            AppUser user33 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "664039531388552" },
                
                FName = "Sarah",
                LName = "Saunders",
                UserName = strEmail33,
                Email = strEmail33,
                City = "Austin",
                PhoneNumber = "5123497810",
                StreeAddress = "332 Avenue C",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd33 = userManager.FindByName(strEmail33);
            if (userToAdd33 == null) //this user doesn't exist anymore
            {
                userManager.Create(user33, "8f45896");
                userToAdd33 = userManager.FindByName(strEmail33);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd33.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd33.Id, roleName1);
            }
            //create a user
            String strEmail34 = "willsheff@email.com";
            AppUser user34 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5415140475671290" },
                
                FName = "William",
                LName = "Sewell",
                UserName = strEmail34,
                Email = strEmail34,
                City = "Austin",
                PhoneNumber = "5124510084",
                StreeAddress = "2365 51st St.",
                State = "TX",
                Zip = "78709"
            };
            //see if the user is already there
            AppUser userToAdd34 = userManager.FindByName(strEmail34);
            if (userToAdd34 == null) //this user doesn't exist anymore
            {
                userManager.Create(user34, "409gtio23");
                userToAdd34 = userManager.FindByName(strEmail34);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd34.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd34.Id, roleName1);
            }
            //create a user
            String strEmail35 = "sheff44@ggmail.com";
            AppUser user35 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6962592004533190" },
                
                FName = "Martin",
                LName = "Sheffield",
                UserName = strEmail35,
                Email = strEmail35,
                City = "Austin",
                PhoneNumber = "5125479167",
                StreeAddress = "3886 Avenue A",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd35 = userManager.FindByName(strEmail35);
            if (userToAdd35 == null) //this user doesn't exist anymore
            {
                userManager.Create(user35, "k4589h98cx");
                userToAdd35 = userManager.FindByName(strEmail35);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd35.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd35.Id, roleName1);
            }
            //create a user
            String strEmail36 = "johnsmith187@aool.com";
            AppUser user36 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "717796136488089" },
                
                FName = "John",
                LName = "Smith",
                UserName = strEmail36,
                Email = strEmail36,
                City = "San Antonio",
                PhoneNumber = "2108321888",
                StreeAddress = "23 Hidden Forge Dr.",
                State = "TX",
                Zip = "78280"
            };
            //see if the user is already there
            AppUser userToAdd36 = userManager.FindByName(strEmail36);
            if (userToAdd36 == null) //this user doesn't exist anymore
            {
                userManager.Create(user36, "n98k03k9hh");
                userToAdd36 = userManager.FindByName(strEmail36);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd36.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd36.Id, roleName1);
            }
            //create a user
            String strEmail37 = "dustroud@mail.com";
            AppUser user37 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5468749400262880" },
                
                FName = "Dustin",
                LName = "Stroud",
                UserName = strEmail37,
                Email = strEmail37,
                City = "Dallas",
                PhoneNumber = "2142346667",
                StreeAddress = "1212 Rita Rd",
                State = "TX",
                Zip = "75221"
            };
            //see if the user is already there
            AppUser userToAdd37 = userManager.FindByName(strEmail37);
            if (userToAdd37 == null) //this user doesn't exist anymore
            {
                userManager.Create(user37, "d25k758e3");
                userToAdd37 = userManager.FindByName(strEmail37);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd37.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd37.Id, roleName1);
            }
            //create a user
            String strEmail38 = "eric_stuart@aool.com";
            AppUser user38 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6780588472896630" },
                CC2 = new CreditCard() { CCNumber = "4981762270647820" },
                FName = "Eric",
                LName = "Stuart",
                UserName = strEmail38,
                Email = strEmail38,
                City = "Austin",
                PhoneNumber = "5128178335",
                StreeAddress = "5576 Toro Ring",
                State = "TX",
                Zip = "78746"
            };
            //see if the user is already there
            AppUser userToAdd38 = userManager.FindByName(strEmail38);
            if (userToAdd38 == null) //this user doesn't exist anymore
            {
                userManager.Create(user38, "e09rf0fk0f");
                userToAdd38 = userManager.FindByName(strEmail38);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd38.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd38.Id, roleName1);
            }
            //create a user
            String strEmail39 = "peterstump@hootmail.com";
            AppUser user39 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "440279517306779" },
                CC2 = new CreditCard() { CCNumber = "714543621891322" },
                FName = "Peter",
                LName = "Stump",
                UserName = strEmail39,
                Email = strEmail39,
                City = "Houston",
                PhoneNumber = "8174560903",
                StreeAddress = "1300 Kellen Circle",
                State = "TX",
                Zip = "77018"
            };
            //see if the user is already there
            AppUser userToAdd39 = userManager.FindByName(strEmail39);
            if (userToAdd39 == null) //this user doesn't exist anymore
            {
                userManager.Create(user39, "l0j87j33jbv");
                userToAdd39 = userManager.FindByName(strEmail39);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd39.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd39.Id, roleName1);
            }
            //create a user
            String strEmail40 = "tanner@ggmail.com";
            AppUser user40 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5422935985121310" },
                CC2 = new CreditCard() { CCNumber = "5477132658283840" },
                FName = "Jeremy",
                LName = "Tanner",
                UserName = strEmail40,
                Email = strEmail40,
                City = "Houston",
                PhoneNumber = "8174590929",
                StreeAddress = "4347 Almstead",
                State = "TX",
                Zip = "77044"
            };
            //see if the user is already there
            AppUser userToAdd40 = userManager.FindByName(strEmail40);
            if (userToAdd40 == null) //this user doesn't exist anymore
            {
                userManager.Create(user40, "iu73498dd");
                userToAdd40 = userManager.FindByName(strEmail40);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd40.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd40.Id, roleName1);
            }
            //create a user
            String strEmail41 = "taylordjay@aool.com";
            AppUser user41 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4247987109036310" },
                CC2 = new CreditCard() { CCNumber = "860245686047451" },
                FName = "Allison",
                LName = "Taylor",
                UserName = strEmail41,
                Email = strEmail41,
                City = "Austin",
                PhoneNumber = "5124748452",
                StreeAddress = "467 Nueces St.",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd41 = userManager.FindByName(strEmail41);
            if (userToAdd41 == null) //this user doesn't exist anymore
            {
                userManager.Create(user41, "y87hu9ik");
                userToAdd41 = userManager.FindByName(strEmail41);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd41.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd41.Id, roleName1);
            }
            //create a user
            String strEmail42 = "y87hu9ik.Taylor@aool.com";
            AppUser user42 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6761707076925830" },
                CC2 = new CreditCard() { CCNumber = "4590566912856230" },
                FName = "Rachel",
                LName = "Taylor",
                UserName = strEmail42,
                Email = strEmail42,
                City = "Austin",
                PhoneNumber = "5124512631",
                StreeAddress = "345 Longview Dr.",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd42 = userManager.FindByName(strEmail42);
            if (userToAdd42 == null) //this user doesn't exist anymore
            {
                userManager.Create(user42, "fio076jfh");
                userToAdd42 = userManager.FindByName(strEmail42);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd42.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd42.Id, roleName1);
            }
            //create a user
            String strEmail43 = "tee_frank@hootmail.com";
            AppUser user43 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "168073130658754" },
                CC2 = new CreditCard() { CCNumber = "6167268833061390" },
                FName = "Frank",
                LName = "Tee",
                UserName = strEmail43,
                Email = strEmail43,
                City = "Houston",
                PhoneNumber = "8178765543",
                StreeAddress = "5590 Lavell Dr",
                State = "TX",
                Zip = "77004"
            };
            //see if the user is already there
            AppUser userToAdd43 = userManager.FindByName(strEmail43);
            if (userToAdd43 == null) //this user doesn't exist anymore
            {
                userManager.Create(user43, "q234k0jiee");
                userToAdd43 = userManager.FindByName(strEmail43);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd43.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd43.Id, roleName1);
            }
            //create a user
            String strEmail44 = "tuck33@ggmail.com";
            AppUser user44 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5432667042375460" },
                CC2 = new CreditCard() { CCNumber = "6465504285538790" },
                FName = "Clent",
                LName = "Tucker",
                UserName = strEmail44,
                Email = strEmail44,
                City = "Dallas",
                PhoneNumber = "2148471154",
                StreeAddress = "312 Main St.",
                State = "TX",
                Zip = "75315"
            };
            //see if the user is already there
            AppUser userToAdd44 = userManager.FindByName(strEmail44);
            if (userToAdd44 == null) //this user doesn't exist anymore
            {
                userManager.Create(user44, "z98ytre38");
                userToAdd44 = userManager.FindByName(strEmail44);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd44.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd44.Id, roleName1);
            }
            //create a user
            String strEmail45 = "avelasco@yaho.com";
            AppUser user45 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "4368667972354250" },
                CC2 = new CreditCard() { CCNumber = "351777302204025" },
                FName = "Allen",
                LName = "Velasco",
                UserName = strEmail45,
                Email = strEmail45,
                City = "Dallas",
                PhoneNumber = "2143985638",
                StreeAddress = "679 W. 4th",
                State = "TX",
                Zip = "75207"
            };
            //see if the user is already there
            AppUser userToAdd45 = userManager.FindByName(strEmail45);
            if (userToAdd45 == null) //this user doesn't exist anymore
            {
                userManager.Create(user45, "vq34yx34670");
                userToAdd45 = userManager.FindByName(strEmail45);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd45.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd45.Id, roleName1);
            }
            //create a user
            String strEmail46 = "westj@pioneer.net";
            AppUser user46 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "6589854795728270" },
                CC2 = new CreditCard() { CCNumber = "4579224077662870" },
                FName = "Jake",
                LName = "West",
                UserName = strEmail46,
                Email = strEmail46,
                City = "Dallas",
                PhoneNumber = "2148475244",
                StreeAddress = "RR 3287",
                State = "TX",
                Zip = "75323"
            };
            //see if the user is already there
            AppUser userToAdd46 = userManager.FindByName(strEmail46);
            if (userToAdd46 == null) //this user doesn't exist anymore
            {
                userManager.Create(user46, "ghr89i32k8");
                userToAdd46 = userManager.FindByName(strEmail46);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd46.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd46.Id, roleName1);
            }
            //create a user
            String strEmail47 = "louielouie@aool.com";
            AppUser user47 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "238153423810050" },
                CC2 = new CreditCard() { CCNumber = "6270385324417050" },
                FName = "Louis",
                LName = "Winthorpe",
                UserName = strEmail47,
                Email = strEmail47,
                City = "Austin",
                PhoneNumber = "2145650098",
                StreeAddress = "2500 Padre Blvd",
                State = "TX",
                Zip = "78746"
            };
            //see if the user is already there
            AppUser userToAdd47 = userManager.FindByName(strEmail47);
            if (userToAdd47 == null) //this user doesn't exist anymore
            {
                userManager.Create(user47, "kji0338jjg");
                userToAdd47 = userManager.FindByName(strEmail47);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd47.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd47.Id, roleName1);
            }
            //create a user
            String strEmail48 = "rwood@voyager.net";
            AppUser user48 = new AppUser()
            {
                CC1 = new CreditCard() { CCNumber = "5448275652910170" },
                CC2 = new CreditCard() { CCNumber = "6294260418333300" },
                FName = "Reagan",
                LName = "Wood",
                UserName = strEmail48,
                Email = strEmail48,
                City = "Austin",
                PhoneNumber = "5124545242",
                StreeAddress = "447 Westlake Dr.",
                State = "TX",
                Zip = "78746"
            };
            //see if the user is already there
            AppUser userToAdd48 = userManager.FindByName(strEmail48);
            if (userToAdd48 == null) //this user doesn't exist anymore
            {
                userManager.Create(user48, "jz3i0q7");
                userToAdd48 = userManager.FindByName(strEmail48);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd48.Id, roleName1) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd48.Id, roleName1);
            }
            //create a manager role
            String roleName2 = "Manager";
            //check to see if the role exists
            if (roleManager.RoleExists(roleName2) == false) //role doesn't exist
            {
                roleManager.Create(new AppRole(roleName2));
            }

            //create a manager
            String strEmail100 = "taylor@longhornsmusic.com";
            AppUser user100 = new AppUser()
            {
                FName = "Allison",
                LName = "Taylor",
                UserName = strEmail100,
                Email = strEmail100,
                City = "Dallas",
                PhoneNumber = "2148965621",
                StreeAddress = "467 Nueces St.",
                State = "TX",
                Zip = "75237"
            };
            //see if the user is already there
            AppUser userToAdd100 = userManager.FindByName(strEmail100);
            if (userToAdd100 == null) //this user doesn't exist anymore
            {
                userManager.Create(user100, "BU9563");
                userToAdd100 = userManager.FindByName(strEmail100);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd100.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd100.Id, roleName2);
            }
            //create a manager
            String strEmail101 = "sheffield@longhornsmusic.com";
            AppUser user101 = new AppUser()
            {
                FName = "Martin",
                LName = "Sheffield",
                UserName = strEmail101,
                Email = strEmail101,
                City = "Austin",
                PhoneNumber = "5124678821",
                StreeAddress = "3886 Avenue A",
                State = "TX",
                Zip = "78736"
            };
            //see if the user is already there
            AppUser userToAdd101 = userManager.FindByName(strEmail101);
            if (userToAdd101 == null) //this user doesn't exist anymore
            {
                userManager.Create(user101, "longhorns");
                userToAdd101 = userManager.FindByName(strEmail101);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd101.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd101.Id, roleName2);
            }
            //create a manager
            String strEmail102 = "macleod@longhornsmusic.com";
            AppUser user102 = new AppUser()
            {
                FName = "Jennifer",
                LName = "MacLeod",
                UserName = strEmail102,
                Email = strEmail102,
                City = "Austin",
                PhoneNumber = "5124653365",
                StreeAddress = "2504 Far West Blvd.",
                State = "TX",
                Zip = "78731"
            };
            //see if the user is already there
            AppUser userToAdd102 = userManager.FindByName(strEmail102);
            if (userToAdd102 == null) //this user doesn't exist anymore
            {
                userManager.Create(user102, "smitty");
                userToAdd102 = userManager.FindByName(strEmail102);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd102.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd102.Id, roleName2);
            }
            //create a manager
            String strEmail103 = "rhodes@longhornsmusic.com";
            AppUser user103 = new AppUser()
            {
                FName = "Megan",
                LName = "Rhodes",
                UserName = strEmail103,
                Email = strEmail103,
                City = "San Antonio",
                PhoneNumber = "2102449976",
                StreeAddress = "4587 Enfield Rd.",
                State = "TX",
                Zip = "78293"
            };
            //see if the user is already there
            AppUser userToAdd103 = userManager.FindByName(strEmail103);
            if (userToAdd103 == null) //this user doesn't exist anymore
            {
                userManager.Create(user103, "countryrhodes");
                userToAdd103 = userManager.FindByName(strEmail103);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd103.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd103.Id, roleName2);
            }
            //create a manager
            String strEmail104 = "stuart@longhornsmusic.com";
            AppUser user104 = new AppUser()
            {
                FName = "Eric",
                LName = "Stuart",
                UserName = strEmail104,
                Email = strEmail104,
                City = "San Antonio",
                PhoneNumber = "2105344627",
                StreeAddress = "5576 Toro Ring",
                State = "TX",
                Zip = "78279"
            };
            //see if the user is already there
            AppUser userToAdd104 = userManager.FindByName(strEmail104);
            if (userToAdd104 == null) //this user doesn't exist anymore
            {
                userManager.Create(user104, "stewboy");
                userToAdd104 = userManager.FindByName(strEmail104);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd104.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd104.Id, roleName2);
            }
            //create a manager
            String strEmail105 = "swanson@longhornsmusic.com";
            AppUser user105 = new AppUser()
            {
                FName = "Leon",
                LName = "Swanson",
                UserName = strEmail105,
                Email = strEmail105,
                City = "Austin",
                PhoneNumber = "5124748138",
                StreeAddress = "245 River Rd",
                State = "TX",
                Zip = "78731"
            };
            //see if the user is already there
            AppUser userToAdd105 = userManager.FindByName(strEmail105);
            if (userToAdd105 == null) //this user doesn't exist anymore
            {
                userManager.Create(user105, "swansong");
                userToAdd105 = userManager.FindByName(strEmail105);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd105.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd105.Id, roleName2);
            }
            //create a manager
            String strEmail106 = "white@longhornsmusic.com";
            AppUser user106 = new AppUser()
            {
                FName = "Jason",
                LName = "White",
                UserName = strEmail106,
                Email = strEmail106,
                City = "Houston",
                PhoneNumber = "8174955201",
                StreeAddress = "12 Valley View",
                State = "TX",
                Zip = "77045"
            };
            //see if the user is already there
            AppUser userToAdd106 = userManager.FindByName(strEmail106);
            if (userToAdd106 == null) //this user doesn't exist anymore
            {
                userManager.Create(user106, "123456");
                userToAdd106 = userManager.FindByName(strEmail106);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd106.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd106.Id, roleName2);
            }
            //create a manager
            String strEmail107 = "montgomery@longhornsmusic.com";
            AppUser user107 = new AppUser()
            {
                FName = "Wilda",
                LName = "Montgomery",
                UserName = strEmail107,
                Email = strEmail107,
                City = "Houston",
                PhoneNumber = "8178746718",
                StreeAddress = "210 Blanco Dr",
                State = "TX",
                Zip = "77030"
            };
            //see if the user is already there
            AppUser userToAdd107 = userManager.FindByName(strEmail107);
            if (userToAdd107 == null) //this user doesn't exist anymore
            {
                userManager.Create(user107, "monty3");
                userToAdd107 = userManager.FindByName(strEmail107);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd107.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd107.Id, roleName2);
            }
            //create a manager
            String strEmail108 = "walker@longhornsmusic.com";
            AppUser user108 = new AppUser()
            {
                FName = "Larry",
                LName = "Walker",
                UserName = strEmail108,
                Email = strEmail108,
                City = "Dallas",
                PhoneNumber = "2143125897",
                StreeAddress = "9 Bison Circle",
                State = "TX",
                Zip = "75238"
            };
            //see if the user is already there
            AppUser userToAdd108 = userManager.FindByName(strEmail108);
            if (userToAdd108 == null) //this user doesn't exist anymore
            {
                userManager.Create(user108, "walkamile");
                userToAdd108 = userManager.FindByName(strEmail108);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd108.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd108.Id, roleName2);
            }
            //create a manager
            String strEmail109 = "chang@longhornsmusic.com";
            AppUser user109 = new AppUser()
            {
                FName = "George",
                LName = "Chang",
                UserName = strEmail109,
                Email = strEmail109,
                City = "San Antonio",
                PhoneNumber = "2103450925",
                StreeAddress = "9003 Joshua St",
                State = "TX",
                Zip = "78260"
            };
            //see if the user is already there
            AppUser userToAdd109 = userManager.FindByName(strEmail109);
            if (userToAdd109 == null) //this user doesn't exist anymore
            {
                userManager.Create(user109, "changalang");
                userToAdd109 = userManager.FindByName(strEmail109);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd109.Id, roleName2) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd109.Id, roleName2);
            }
            //create an employee role
            String roleName3 = "Employee";
            //check to see if the role exists
            if (roleManager.RoleExists(roleName3) == false) //role doesn't exist
            {
                roleManager.Create(new AppRole(roleName3));
            }

            //create an employee
            String strEmail111 = "jacobs@longhornsmusic.com";
            AppUser user111 = new AppUser()
            {
                FName = "Todd",
                LName = "Jacobs",
                UserName = strEmail111,
                Email = strEmail111,
                City = "Houston",
                PhoneNumber = "8176593544",
                StreeAddress = "4564 Elm St.",
                State = "TX",
                Zip = "77003"
            };
            //see if the user is already there
            AppUser userToAdd111 = userManager.FindByName(strEmail111);
            if (userToAdd111 == null) //this user doesn't exist anymore
            {
                userManager.Create(user111, "tj2222");
                userToAdd111 = userManager.FindByName(strEmail111);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd111.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd111.Id, roleName3);
            }

            //create an employee
            String strEmail112 = "rice@longhornsmusic.com";
            AppUser user112 = new AppUser()
            {
                FName = "Eryn",
                LName = "Rice",
                UserName = strEmail112,
                Email = strEmail112,
                City = "Dallas",
                PhoneNumber = "2148475583",
                StreeAddress = "3405 Rio Grande",
                State = "TX",
                Zip = "75261"
            };
            //see if the user is already there
            AppUser userToAdd112 = userManager.FindByName(strEmail112);
            if (userToAdd112 == null) //this user doesn't exist anymore
            {
                userManager.Create(user112, "ricearoni");
                userToAdd112 = userManager.FindByName(strEmail112);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd112.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd112.Id, roleName3);
            }

            //create an employee
            String strEmail113 = "ingram@longhornsmusic.com";
            AppUser user113 = new AppUser()
            {
                FName = "Brad",
                LName = "Ingram",
                UserName = strEmail113,
                Email = strEmail113,
                City = "Austin",
                PhoneNumber = "5126978613",
                StreeAddress = "6548 La Posada Ct.",
                State = "TX",
                Zip = "78705"
            };
            //see if the user is already there
            AppUser userToAdd113 = userManager.FindByName(strEmail113);
            if (userToAdd113 == null) //this user doesn't exist anymore
            {
                userManager.Create(user113, "ingram45");
                userToAdd113 = userManager.FindByName(strEmail113);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd113.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd113.Id, roleName3);
            }

            //create an employee
            String strEmail114 = "martinez@longhornsmusic.com";
            AppUser user114 = new AppUser()
            {
                FName = "Gregory",
                LName = "Martinez",
                UserName = strEmail114,
                Email = strEmail114,
                City = "San Antonio",
                PhoneNumber = "2105788965",
                StreeAddress = "8295 Sunset Blvd.",
                State = "TX",
                Zip = "78239"
            };
            //see if the user is already there
            AppUser userToAdd114 = userManager.FindByName(strEmail114);
            if (userToAdd114 == null) //this user doesn't exist anymore
            {
                userManager.Create(user114, "marty");
                userToAdd114 = userManager.FindByName(strEmail114);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd114.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd114.Id, roleName3);
            }

            //create an employee
            String strEmail115 = "tanner@longhornsmusic.com";
            AppUser user115 = new AppUser()
            {
                FName = "Jeremy",
                LName = "Tanner",
                UserName = strEmail115,
                Email = strEmail115,
                City = "Austin",
                PhoneNumber = "5129457399",
                StreeAddress = "4347 Almstead",
                State = "TX",
                Zip = "78761"
            };
            //see if the user is already there
            AppUser userToAdd115 = userManager.FindByName(strEmail115);
            if (userToAdd115 == null) //this user doesn't exist anymore
            {
                userManager.Create(user115, "tanman");
                userToAdd115 = userManager.FindByName(strEmail115);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd115.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd115.Id, roleName3);
            }

            //create an employee
            String strEmail116 = "chung@longhornsmusic.com";
            AppUser user116 = new AppUser()
            {
                FName = "Lisa",
                LName = "Chung",
                UserName = strEmail116,
                Email = strEmail116,
                City = "San Antonio",
                PhoneNumber = "2106983548",
                StreeAddress = "234 RR 12",
                State = "TX",
                Zip = "78268"
            };
            //see if the user is already there
            AppUser userToAdd116 = userManager.FindByName(strEmail116);
            if (userToAdd116 == null) //this user doesn't exist anymore
            {
                userManager.Create(user116, "lisssa");
                userToAdd116 = userManager.FindByName(strEmail116);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd116.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd116.Id, roleName3);
            }

            //create an employee
            String strEmail117 = "loter@longhornsmusic.com";
            AppUser user117 = new AppUser()
            {
                FName = "Wanda",
                LName = "Loter",
                UserName = strEmail117,
                Email = strEmail117,
                City = "Austin",
                PhoneNumber = "5124579845",
                StreeAddress = "3453 RR 3235",
                State = "TX",
                Zip = "78732"
            };
            //see if the user is already there
            AppUser userToAdd117 = userManager.FindByName(strEmail117);
            if (userToAdd117 == null) //this user doesn't exist anymore
            {
                userManager.Create(user117, "lottery");
                userToAdd117 = userManager.FindByName(strEmail117);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd117.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd117.Id, roleName3);
            }

            //create an employee
            String strEmail118 = "morales@longhornsmusic.com";
            AppUser user118 = new AppUser()
            {
                FName = "Hector",
                LName = "Morales",
                UserName = strEmail118,
                Email = strEmail118,
                City = "Houston",
                PhoneNumber = "8177458615",
                StreeAddress = "4501 RR 140",
                State = "TX",
                Zip = "77031"
            };
            //see if the user is already there
            AppUser userToAdd118 = userManager.FindByName(strEmail118);
            if (userToAdd118 == null) //this user doesn't exist anymore
            {
                userManager.Create(user118, "hecktour");
                userToAdd118 = userManager.FindByName(strEmail118);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd118.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd118.Id, roleName3);
            }

            //create an employee
            String strEmail119 = "rankin@longhornsmusic.com";
            AppUser user119 = new AppUser()
            {
                FName = "Mary",
                LName = "Rankin",
                UserName = strEmail119,
                Email = strEmail119,
                City = "Austin",
                PhoneNumber = "5122926966",
                StreeAddress = "340 Second St",
                State = "TX",
                Zip = "78703"
            };
            //see if the user is already there
            AppUser userToAdd119 = userManager.FindByName(strEmail119);
            if (userToAdd119 == null) //this user doesn't exist anymore
            {
                userManager.Create(user119, "rankmary");
                userToAdd119 = userManager.FindByName(strEmail119);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd119.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd119.Id, roleName3);
            }

            //create an employee
            String strEmail120 = "gonzalez@longhornsmusic.com";
            AppUser user120 = new AppUser()
            {
                FName = "Gwen",
                LName = "Gonzalez",
                UserName = strEmail120,
                Email = strEmail120,
                City = "Dallas",
                PhoneNumber = "2142345566",
                StreeAddress = "103 Manor Rd",
                State = "TX",
                Zip = "75260"
            };
            //see if the user is already there
            AppUser userToAdd120 = userManager.FindByName(strEmail120);
            if (userToAdd120 == null) //this user doesn't exist anymore
            {
                userManager.Create(user120, "gg2003");
                userToAdd120 = userManager.FindByName(strEmail120);
            }
            //add the user to the role
            if (userManager.IsInRole(userToAdd120.Id, roleName3) == false)
            //the user isn't in the role
            {
                userManager.AddToRole(userToAdd120.Id, roleName3);
            }

        }
    }
    //    void AddOrUpdateArtistGenre(AppDbContext db, string artistName, string genreName)
    //    {
    //        Genre genre = db.Genres.SingleOrDefault(g => g.GenreName == genreName);
    //        Artist artist = db.Artists.SingleOrDefault(a => a.ArtistName ==
    //artistName);
    //        artist.ArtistGenre.Add(genre);
    //    }
    }

