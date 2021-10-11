using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина строки не более 25 символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина строки не более 30 символов")]
        public string surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(50)]
        [Required(ErrorMessage = "Длина строки не более 50 символов")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        [Required(ErrorMessage = "Длина строки не более 11 символов")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required(ErrorMessage = "Длина строки не более 50 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }


    }
}
