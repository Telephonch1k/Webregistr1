using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Webregistr1.Models
{
    public class User : IdentityUser
    {
        //Дополнительные поля для пользователей
        //Для преподавателя погут понадобиться данные о ФИО

        //Сообщение об ошибке при валидации на стороне клиента
        [Required(ErrorMessage = "Введите фамилию")]

        //Отображение фамилии вместо LastName
        [Display(Name = "Фамилиииия")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите отчество")]
        [Display(Name = "Отчество")]

        public string Patronymic { get; set; }

       //Навигационные свойства
    }
}
