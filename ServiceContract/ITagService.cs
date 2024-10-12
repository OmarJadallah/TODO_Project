
using ServiceContract.DTO;

namespace ServiceContract
{
    public interface ITagService
    {
        TagDTO CreateTag(string tagName);
        bool DeleteTag(Guid tagID);
        TagDTO UpdateTag(TagDTO tag);
        TagDTO? GetTag(Guid tagID);
        TagDTO? GetTag(string tagName);
        List<TagDTO> GetAllTags();



    }
}
