using Entities;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectInitializationOfProduct()
        {
            // Arrange:
            int id = 1;
            string name = "Mads";

            // Act:
            Product p = new Product(id, name);


            // Assert:
            Assert.Equal(id, p.Id);
            Assert.Equal(name, p.Name);
            Assert.True(p.Id > 0);
            Assert.NotNull(p.Name);
        }
    }
}