using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    [Table ("AccountList"),PrimaryKey("Account_ID")]
    public class Account
    {
        [StringLength(3),NotNull]
        public string Account_ID { get; set; }
        [StringLength(20)]
        public string Account_Username { get; set; }
        [StringLength(20)]
        public string Account_Password { get; set;}
        private byte IsManager {  get; set; }
        [NotMapped]
        public string Job_Title => IsManager == 1 ? "Quản lý" : "Nhân viên";
    }
}
