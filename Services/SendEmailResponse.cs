﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeDesignFood.Email
{
    /// <summary>
    /// A response from a SendEmail call for any <see cref="IEmailSender"/> implementation
    /// </summary>
    public class SendEmailResponse
    {
        /// <summary>
        /// True if the email was sent successfully
        /// </summary>
        public bool Successful => ErrorMessage == null;

        /// <summary>
        /// The error message if the sending failed
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}

