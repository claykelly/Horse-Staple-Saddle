﻿using System;
using System.Net;
using System.Net.Mail;
using Team9.Models;

namespace Team9.Messaging
{
    public class EmailMessage
    {
        public  void confirmPurchaseEmail(AppUser a, Purchase p, Artist recArtist)
        {
            if (p.isGift == true)
            {
                String destinationEmail = a.Email;
                String refundLink = "www.ourwebsite.com/Purchases/Refund/" + p.PurchaseID.ToString();
                String emailSubject = "Team9" + a.FName + " " + a.LName + " Order #" + p.PurchaseID.ToString() + " Details";
                String emailBody = "Dear" + a.FName + ",\nYour Order you gifted to " + p.GiftUser.FName + " is Confirmed. We also recommend you check out " + recArtist.ArtistName + " if this order is a mistake, click this link " + refundLink;
                SendEmail(destinationEmail, emailSubject, emailBody);

                String dest = p.GiftUser.Email;
                String emailSubjectGuest = "Team9" + p.GiftUser.FName + " " + p.GiftUser.LName + " Order #" + p.PurchaseID.ToString() + " Details";
                String emailBod = "Dear" + a.FName + ",\nYour Gifted Order From " + a.FName + "is Confirmed. We also recommend you check out " + recArtist.ArtistName + " if this order is a mistake, click this link www.ourwebsite.com/Purchases/Refund/" + refundLink;
                SendEmail(dest, emailSubjectGuest, emailBod);
            }
            else
            {
                String destinationEmail = a.Email;
                String refundLink = "www.ourwebsite.com/Purchases/Refund/" + p.PurchaseID.ToString();
                String emailSubject = "Team9" + a.FName + " " + a.LName + " Order #" + p.PurchaseID.ToString() + " Details";
                String emailBody = "Dear" + a.FName + ",\nYour Order is Confirmed. We also recommend you check out " + recArtist.ArtistName + " if this order is a mistake, click this link www.ourwebsite.com/Purchases/Refund/" + refundLink;
                SendEmail(destinationEmail, emailSubject, emailBody);
            }


        }
        public  void confirmRegistrationEmail(AppUser a, Purchase p, Artist recartist)
        {
            String destinationEmail = a.Email;
            //String refundLink = "www.ourwebsite.com/Purchases/Refund/" + p.PurchaseID.ToString();
            String emailSubject = "Team9" + a.FName + " " + a.LName + " Order #" + p.PurchaseID.ToString() + " Details";
            String emailBody = "Dear" + a.FName + ",\nYour Order is Confirmed. We also recommend you check out " + recartist.ArtistName + " if this order is a mistake, click this link www.ourwebsite.com/Purchases/Refund/";
            SendEmail(destinationEmail, emailSubject, emailBody);
        }

        public static void SendEmail(String toEmailAddress, String emailSubject, String emailBody)
        {
            //create an email client to send emails
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("longhornmusic0@gmail.com", "shanebuechele"),
                EnableSsl = true
            };

            //add anything you need to the body of the message
            // /n is a new line -  this will add some white space after the main body of the message
            String finalMessage = emailBody + "\n\n This is a disclaimer that will be on all messages";

            //create an email address object for the sender address
            MailAddress senderEmail = new MailAddress("longhornmusic0@gmail.com", "Team 9");

            MailMessage mm = new MailMessage();
            mm.Subject = emailSubject;
            mm.From = senderEmail;
            mm.To.Add(new MailAddress("longhornmusic0@gmail.com"));
            mm.Body = finalMessage;
            client.Send(mm);
        }

        
    }
}