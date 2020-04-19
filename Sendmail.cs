public string SendMail(string email, string message, string subject)
{
    try
    {
        MailMessage objMail = new MailMessage("futuremfana@mail.com", email, subject, message);
        objMail.Priority = MailPriority.High;
        objMail.IsBodyHtml = true;

        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("futuremfana@mail.com", "Pa55w.rd");
        smtp.EnableSsl = true;
        smtp.SendMailAsync(objMail);

        return "true";
    }
    catch (Exception ex)
    {
        return ex.ToString();
    }
}
