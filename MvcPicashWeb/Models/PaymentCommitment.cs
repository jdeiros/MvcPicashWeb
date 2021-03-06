﻿using System;
using System.Collections.Generic;

namespace MvcPicashWeb.Models
{
    public class PaymentCommitment
    {
        public string PaymentCommitmentId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public float TotalAmmount { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Installment> Installments { get; set; }
        public PaymentcommitmentStatus PaymentcommitmentStatus { get; set; }

        public PaymentCommitment()
        {
        }
    }
}
