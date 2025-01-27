﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarVol.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        public string AppUserId { get; set; }
        [ForeignKey("AppUserId")]

        public AppUser AppUser { get; set; }


        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime ShippingDate { get; set; }

        [NotMapped]
        public Double CompanyOrderTotalBeforeDiscount { get; set; } 

        [Required]
        public Double OrderTotal { get; set; }





        public string TrackingNumber { get; set; }

        public string Carrier { get; set; }

        public string OrderStatus { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime PaymentDate { get; set; }

        public DateTime PaymentDueDate { get; set; }

        public string TransactionId { get; set; }


        [Required]
       
        public string Name { get; set; }

        [Required]
       
        public string Street { get; set; }

        [Required]
   
        public string City { get; set; }

        [Required]
     
        public string Country { get; set; }

        [Required]
 
        public string PostalCode { get; set; }

        [Required]
   
        public string PhoneNumber { get; set; }

        


    }
}
