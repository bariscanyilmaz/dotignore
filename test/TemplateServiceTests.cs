using Options;
using Services;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using Models;

namespace dotignore.test
{
    public class TemplateServiceTests
    {
        [Theory]
        [InlineData("c","c")]
        [InlineData("go","go")]
        [InlineData("golang","go")]
        [InlineData("dotnet","csharp")]
        public void FindTemplate_ShouldReturnTemplate_WhenTemplateIsFound(string query,string expected)
        {

            var templateService = new TemplateService();
            var option = new InitOption() { Template = query };

            var result = templateService.FindTemplate(option);
            
            Assert.Equal(expected,result.Name);

        }

        [Theory]
        [InlineData("asd")]
        [InlineData("ff")]
        [InlineData("cart")]
        [InlineData("curt")]
        public void FindTemplate_ShouldReturnNull_WhenTemplateNotFound(string query)
        {

            var templateService = new TemplateService();
            var option = new InitOption() { Template = query };

            var result = templateService.FindTemplate(option);
            
            Assert.Null(result);

        }

        [Fact]
        public void ListTemplates_ShouldReturnAll_WhenOptionNull()
        {   
            var templateService=new TemplateService();
            var option=new ListOption(){Query=null};

            var result= templateService.ListTemplates(option);

            Assert.Equal(Repository.Templates.ToList().Count,result.ToList().Count);
        }

        [Fact]
        public void ListTemplates_ShouldReturnEmpty_WhenQueryNotFound()
        {   
            var templateService=new TemplateService();
            var option=new ListOption(){Query="invalid option"};

            List<Template> result= templateService.ListTemplates(option).ToList();

            Assert.Empty(result);
        }

        [Theory]
        [InlineData("csharp",1)]
        [InlineData("go",2)]
        [InlineData("django",1)]
        [InlineData("c",6)]
        [InlineData("wordpress",1)]
        [InlineData("unity",1)]
        public void ListTemplates_ShouldReturn_WhenQueryFound(string query,int expected)
        {   
            var templateService=new TemplateService();
            var option=new ListOption(){Query=query};

            List<Template> result= templateService.ListTemplates(option).ToList();

            Assert.Equal(expected,result.Count);
        }
    }
}