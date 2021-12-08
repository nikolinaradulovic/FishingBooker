﻿using FishingBooker.Models;
using FishingBooker.Models.EmailSender;
using FishingBookerLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FishingBooker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminUsersController : Controller
    {
        // GET: AdminUsers
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult InvalidUsers()
        {
            var data = RegUserCRUD.LoadUsers();
            List<RegUserViewModel> users = new List<RegUserViewModel>();
            foreach (var row in data)
            {
                if (row.Status == "Waiting")
                {
                    users.Add(new RegUserViewModel
                    {
                        Name = row.Name,
                        Surname = row.Surname,
                        PhoneNumber = row.PhoneNumber,
                        EmailAddress = row.EmailAddress,
                        Type = row.Type,
                        Address = row.Address,
                        City = row.City,
                        Country = row.Country,
                        Description = row.Description
                    });
                }

            }

            return View(users);
        }

        public ActionResult AllUsers()
        {
            var data = RegUserCRUD.LoadUsers();
            List<RegUserViewModel> users = new List<RegUserViewModel>();
            foreach (var row in data)
            {
                //if (!User.IsInRole("Admin"))
                //{
                    users.Add(new RegUserViewModel
                    {
                        Name = row.Name,
                        Surname = row.Surname,
                        PhoneNumber = row.PhoneNumber,
                        EmailAddress = row.EmailAddress,
                        Type = row.Type,
                        Address = row.Address,
                        City = row.City,
                        Country = row.Country,
                        Description = row.Description
                    });
                //}
            }
            return View(users);
        }

        public ActionResult ValidateUser(string email, string status)
        {
            var gmail = new Gmail {
                To = email,
                Subject = "Account is validated",
                Body = @"Your account is validated, so you can sign in now.
                Thank you for your support.

                Best regards,
                Admin team."

            };
            gmail.SendEmail();
            RegUserCRUD.UpdateUserStatus(email, status);
            return RedirectToAction("InvalidUsers", "AdminUsers");
        }

        public ActionResult RejectUser(string email)
        {
            var gmail = new Gmail
            {
                To = email,
                Subject = "Account is rejected",
                Body = @"Unfortunately, Your account is rejected.Try again with a different information.
                We hope you have an understanding.

                Best regards,
                Admin team."

            };
            gmail.SendEmail();
            int i = RegUserCRUD.DeleteUserByEmail(email);
            return RedirectToAction("InvalidUsers","AdminUsers");
        }
        public ActionResult BlockUser(string email, string status)
        {
            RegUserCRUD.UpdateUserStatus(email, status);
            return RedirectToAction("AllUsers", "AdminUsers");
        }
    }
}