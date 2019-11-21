using Blog.Data.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace Blog.Data.Models
{
  public  class Comment: Entity
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        [MinLength(2)]
        [MaxLength(500)]
        [Required]
        public string Content { get; set; }

        public int? UserId { get; set; }//anonim kullanici olabilir

        public User User { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        
        public string Nickname { get; set; }//anonim için

        [MinLength(6)]
        [MaxLength(320)]
        public string Email { get; set; }//anonim kullaniciya dönüş olduğunda bilgilendirmesi

        public int VoteUp { get; set; }
        public int DownUp { get; set; }




    }
}
