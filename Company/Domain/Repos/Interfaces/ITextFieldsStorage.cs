using System;
using System.Linq;
using Company.Domain.Entities;

namespace Company.Domain.Repos.Interfaces
{
    public interface ITextFieldsStorage
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
