
using Entities;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ServiceContract.DTO
{
    public class TagDTO
    {
        [Required(ErrorMessage = $"{nameof(TagID)} can not be blank !")]
        public Guid TagID { get; set; }

        [Required(ErrorMessage = $"{nameof(TagName)} can not be blank !")]
        public string TagName { get; set; } = string.Empty;


        public override bool Equals(object? obj)
        {
            if ( obj == null ) return false;

            TagDTO? tag = obj as TagDTO;

            if (tag == null) return false;

            return tag.TagID == TagID && tag.TagName == TagName;


        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

    public static class TagExtintion 
    {
        public static TagDTO ToTagDTO(this clsTag tag)
        {
            return new TagDTO { TagID = tag.TagID, TagName = tag.TagName };
        }
    }

}
