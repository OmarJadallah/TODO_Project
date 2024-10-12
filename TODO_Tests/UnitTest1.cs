using ServiceContract;
using ServiceContract.DTO;

namespace TODO_Tests
{
    public class UnitTest1
    {
        private readonly ITagService _tagService;

        public UnitTest1(ITagService tagService)
        {
            _tagService = tagService;
        }


        [Fact]
        public void addTag_ProperValue()
        {
            TagDTO tag = new TagDTO() { TagID = Guid.NewGuid(), TagName = "tag1" };
            List<TagDTO> tags = _tagService.GetAllTags();

            Assert.Contains(tag, tags);
        }

    }
}