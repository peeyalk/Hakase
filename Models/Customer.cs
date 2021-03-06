﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class Customer : BaseEntity
    {
        //[Required(ErrorMessage = "名前(ふり)項目は必須です。")]
        [DisplayName("名前(ふり)")]
        public string NameHira { get; set; }

        //[Required(ErrorMessage = "名前(カタ)項目は必須です。")]
        [DisplayName("名前(カタ)")]
        public string NameKata { get; set; }

        [Required(ErrorMessage = "会社の名前(ふり)項目は必須です。")]
        [DisplayName("会社の名前")]
        public string CompanyNameHira { get; set; }

        //[Required(ErrorMessage = "会社の名前(カタ)項目は必須です。")]
        [DisplayName("会社の名前(カタ)")]
        public string CompanyNameKata { get; set; }

        [EmailAddress(ErrorMessage = "有効な電子メールアドレスではありません。")]
        //[Required(ErrorMessage = "会社の名前(カタ)項目は必須です。")]
        [DisplayName("会社のメール")]
        public string CompanyEmail { get; set; }

        
        public string Pass { get; set; }


        [DisplayName("電話番号")]
        public string Phone { get; set; }


        [DisplayName("携帯番号")]
        public string PhoneMobile { get; set; }

        [DisplayName("生年月日")]
        public DateTime? DateOfBirth { get; set; }

        
        [DisplayName("住所")]
        public string Address { get; set; }

        public IdentityUser User { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [DisplayFormat(NullDisplayText = "-", DataFormatString = "{0:yyyy:MM:dd hh:mm}")]
        public DateTime? LastLoginDate { get; set; }


        public Customer(){ }

        public Customer(string nameHira, string nameKata, string companyNameHira, string companyNameKata, string companyEmail, string phone, string phoneMobile, DateTime? dateOfBirth, string address, IdentityUser user, string userId)
        {
            NameHira = nameHira;
            NameKata = nameKata;
            CompanyNameHira = companyNameHira;
            CompanyNameKata = companyNameKata;
            CompanyEmail = companyEmail;
            Phone = phone;
            PhoneMobile = phoneMobile;
            DateOfBirth = dateOfBirth;
            Address = address;
            User = user;
            UserId = userId;
        }
    }
}
