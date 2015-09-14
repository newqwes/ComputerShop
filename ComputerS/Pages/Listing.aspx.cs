using ComputerS.Models;
using ComputerS.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComputerS.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private int pageSize = 5;

        protected int CurrentPage
        {
            get
            {
                int page;
                page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                return page > MaxPage ? MaxPage : page;
            }
        }
        //свойство, возвращающее наибольший номер допустимой страницы
        protected int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)repository.Computers.Count() / pageSize);
            }
        }
  
        /*Размер страницы задан равным 5 товарам и устанавливается через поле PageSize. Для представления текущей страницы создано свойство CurrentPage, которое использует коллекцию Request.QueryString, определенную базовым классом, для выяснения, присутствует ли значение page в запрошенном URL. Свойство Request предоставляет доступ к деталям текущего запроса. Таким образом, например, если веб-форма обрабатывается для обслуживания URL следующего вида:
        то коллекция Request.QueryString будет содержать ключ page со значением 2. Значения возвращаются из коллекции Request.QueryString в форме строк, поэтому с помощью метода int.TryParse() производится попытка преобразования строки в числовое значение. По умолчанию принято значение 1, которое указывает на отображение первой страницы товаров, когда значение page в строке запроса не задано или преобразовать его не удалось.
        Значения CurrentPage и PageSize позволяют выбирать требуемые объекты Game из хранилища. Метод OrderBy() из LINQ обеспечивает обработку объектов Computer в одном и том же порядке, метод Skip() дает возможность проигнорировать объекты Computer, встречающиеся перед желаемой страницей, а метод Take() позволяет выбрать нужное количество объектов Computer для отображения пользователю. Чтобы протестировать этот код, запустите приложение и несколько раз вручную перейдите на URL разных страниц.*/
        
        protected IEnumerable<Computer> GetComputers()
        {
            return repository.Computers
                .OrderBy(g => g.ComputerId)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}

