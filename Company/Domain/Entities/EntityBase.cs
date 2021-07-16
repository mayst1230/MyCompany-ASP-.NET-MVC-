using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Company.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            DateAdded = DateTime.UtcNow;
        }

        [Required]
        public Guid Id { get; set; }

        [DisplayName("Заголовок")]
        public virtual string Title { get; set; }

        [DisplayName("Краткое описание")]
        public virtual string SubTitle { get; set; }

        [DisplayName("Полное описание")]
        public virtual string Text { get; set; }

        [DisplayName("Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        [DisplayName("SEO метатег Title")]
        public string MetaTitle { get; set; }

        [DisplayName("SEO метатег Description")]
        public string MetaDescription { get; set; }

        [DisplayName("SEO метатег Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
