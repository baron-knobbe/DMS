using System;
using System.IO;
using System.Linq;
using MsgKit;

namespace ScratchPad;

public class EmailManager
{
    static void RemoveAttachment(string emailFilePath, string attachmentName)
    {
        try
        {
            using var msg = new MsgReader.Outlook.Storage.Message(emailFilePath);
            RemoveAttachmentFromEmail(msg, attachmentName);
            //msg.Save();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void RemoveAttachmentFromEmail(MsgReader.Outlook.Storage.Message msg, string attachmentName)
    {
        // Find the attachment by name
        //var attachmentToRemove = msg.Attachments.FirstOrDefault(a => a.FileName == attachmentName);
        var attachmentToRemove = msg.Attachments.FirstOrDefault(a => a.ToString() == attachmentName);

        // Remove the attachment
        if (attachmentToRemove != null)
        {
            msg.Attachments.Remove(attachmentToRemove);
        }
    }
}
