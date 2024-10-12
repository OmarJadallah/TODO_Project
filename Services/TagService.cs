using Entities;
using ServiceContract;
using ServiceContract.DTO;

namespace Services
{
    public class TagService : ITagService
    {
        private readonly List<clsTag> _tags;

        public TagService(bool initialize = true)
        {
            _tags = new List<clsTag>();

            if (initialize)
            {
                _tags.Add(new clsTag() { TagID = Guid.NewGuid() , TagName = "Programming"} );
                _tags.Add(new clsTag() { TagID = Guid.NewGuid(), TagName = "Studying" });
                _tags.Add(new clsTag() { TagID = Guid.NewGuid(), TagName = "Playing" });
            }
        }
        public TagDTO CreateTag(string tagName)
        {
            if (string.IsNullOrEmpty(tagName))
            {
                throw new ArgumentNullException();
            }
            
            if ((_tags.Where(t => t.TagName == tagName).Count()) > 0)
            {
                throw new ArgumentException("the given tag name already used");
            }

            clsTag tag = new clsTag() { TagID = Guid.NewGuid(), TagName = tagName};
            _tags.Add(tag);
            return tag.ToTagDTO();

        }

        public bool DeleteTag(Guid tagID)
        {
            if (tagID == Guid.Empty)
            {
                throw new ArgumentNullException("Tag ID can not be empty");
            }

            clsTag? tag = _tags.Where(t => t.TagID == tagID).FirstOrDefault();

            if (tag == null)
                return false;

            return _tags.Remove(tag);
            
        }

        public List<TagDTO> GetAllTags()
        {
            return _tags.Select(t => _ConvertTagToTagDTO(t)).ToList();
        }

        public TagDTO? GetTag(Guid tagID)
        {
            if (tagID == Guid.Empty)
                throw new ArgumentNullException("tag id can not be empty");

            clsTag? tag = _tags.Where(t => t.TagID == tagID).FirstOrDefault();

            if (tag == null)
                return null;

            return tag.ToTagDTO();
        }

        public TagDTO? GetTag(string tagName)
        {
            if (tagName == null)
                throw new ArgumentNullException("tag name can not be empty");

            clsTag? tag = _tags.Where(t => t.TagName == tagName).FirstOrDefault();

            if (tag == null)
                return null;

            return tag.ToTagDTO();
        }

        public TagDTO UpdateTag(TagDTO tag)
        {
            if (tag == null)
                throw new ArgumentNullException("tag can not be emtpy");


            List<TagDTO> _tagss = GetAllTags();
            TagDTO? mathcingTag = _tagss.Where(t => t.Equals(tag)).FirstOrDefault();


            if (mathcingTag is null)
                throw new ArgumentException("given tag is not found ");

            mathcingTag.TagName = tag.TagName;
            return mathcingTag;


        }

        private TagDTO _ConvertTagToTagDTO(clsTag tag)
        {
            return tag.ToTagDTO();
        }
    }
}
