﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjectEcommerce.src.models
{
    /// <summary>
    /// <para>Resume:Implementing Methods and Constructors for the Users Class </para>
    /// <para>Created by: Matheus Brazolin</para>
    /// <para>version: 1.0</para>
    /// <para>Date: 04/05/2022</para>
    /// </summary>

    [Table("tb_users")]
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string Type { get; set; }
       
        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [JsonIgnore]
        public List<PurchaseModel> MyPurchases { get; set; }
    }
}