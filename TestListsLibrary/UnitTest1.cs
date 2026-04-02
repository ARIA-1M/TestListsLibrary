using static WorkingListsLibrary.ClassLibrary<string>;

namespace TestListsLibrary
{
    public class UnitTest1
    {
        public List<string> list = new List<string> { "Мария", "Мери", "Маша", "Арина", "Настя", "Аня" };
        string item = "Маршал";
        string itemNull = null;
        public List<string> listNull = new List<string>();


       [Fact]
        public void AddListCorrect()//Правильное добавление в лист
        {
            ListHelper.AddList(list, item);
            Assert.Equal(7, list.Count);
        }

        [Fact]
        public void AddListError()//Ошибка добавление в лист
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.AddList(list, itemNull));
        }


        [Fact]
        public void DeletListCorrect()//Правильное удаление из листа
        {
            ListHelper.DeletList(list, item);
            Assert.Equal(6, list.Count);
        }

        [Fact]
        public void DeletListError()//Ошибка удаление из листа
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.DeletList(list, itemNull));
        }

        [Fact]
        public void SearchListCorrect()//Поиск в листе по подстроке
        {
            string input = "Ма";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            var exception = Record.Exception(() => ListHelper.SearchList(list));
            Assert.Null(exception);

        }

        [Fact]
        public void SearchListError()//Ошибка поиска в листе
        {
            string input = "Ма";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            Assert.Throws<ArgumentNullException>(() => ListHelper.SearchList<string>(null));
        }

    }
}
