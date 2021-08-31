using Options;
using Services;
using Xunit;
using System.Collections.Generic;
using Models;

namespace dotignore.test
{
    public class TemplateServiceTests
    {
        [Fact]
        public void FindTemplate_ShoulReturnTemplate_WhenTemplateIsFound()
        {

            var templateService = new TemplateService();
            var option = new InitOption() { Template = "csharp" };

            var result = templateService.FindTemplate(option);
            
            Assert.Equal("csharp",result.Name);

        }

        [Fact]
        public void ListTemplates_ShoulReturnAll_WhenOptionNull()
        {   
            var templateService=new TemplateService();
            var option=new ListOption(){Query=null};

            List<Template> result= templateService.ListTemplates(option);

            Assert.Equal(Repository.Templates.Count,result.Count);
        }

        [Fact]
        public void ListTemplates_ShoulReturnEmpty_WhenQueryNotFound()
        {   
            var templateService=new TemplateService();
            var option=new ListOption(){Query="invalid option"};

            List<Template> result= templateService.ListTemplates(option);

            Assert.Empty(result);
        }

        [Theory]
        [InlineData("csharp",1)]
        [InlineData("go",2)]
        [InlineData("django",1)]
        [InlineData("c",6)]
        [InlineData("wordpress",1)]
        [InlineData("unity",1)]
        public void ListTemplates_ShoulReturn_WhenQueryFound(string query,int expected)
        {   
            var templateService=new TemplateService();
            var option=new ListOption(){Query=query};

            List<Template> result= templateService.ListTemplates(option);

            Assert.Equal(expected,result.Count);
        }
    }
}