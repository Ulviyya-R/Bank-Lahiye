using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulka_Bank.Entities;
using Ulka_Bank.Repositiries;

namespace Ulka_Bank.Service
{
    internal class BankService
    {
        readonly IBankRepository _repository;
        public BankService()
        {
            _repository = new BankRepository();
        }

        #region CheckBalance
        public bool CheckBalance(string password)
        {
            User exicted = default;
            foreach (User item in _repository.Bank.Users)
            {
                if(item.Password == password )
                {
                    exicted = item;
                    Console.WriteLine("duz");
                    _repository.CheckBalance(exicted);
                    return true;
                }
            }
            Console.WriteLine("Sef");
            Thread.Sleep(2000);
                return false;
        }
        #endregion

        #region TopUpBalance
        public bool TopUpBalance(string password, double newBal)
        {
            foreach (User item in _repository.Bank.Users)
            {
                if(item.Password == password )
                {
                    item.Balance += newBal;
                    _repository.TopUpBalance(item);
                    return true;
                }
            }return false;
        }
        #endregion

        #region ChangePassword
        public bool ChangePassword(string currentpas,string newPass)
        {
            User exicted = default;
            foreach (User item in _repository.Bank.Users)
            {
                if (item.Password == currentpas)
                {
                    exicted = item;
                    _repository.ChangePassword(exicted, newPass);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region BankUserList
        public bool BankUserList(string email)
        {
            User exicted;
            foreach (User item in _repository.Bank.Users)
            {
                if (item.Email == email)
                {
                    if (item.IsAdmin == true)
                    {
                        exicted = item;
                        _repository.BankUserList();
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        #endregion

        #region BlocUser
        public bool BlockUser(string email)
        {
            User exicted;
            foreach (User item in _repository.Bank.Users)
            {
                if (item.Email == email)
                {
                    exicted = item;
                    _repository.BlockUser(exicted);
                    return true;
                }
            }
            return false;
        }
        #endregion



        #region LogOut
        public void LogOut(User user)
        {
           _repository.LogOut(user);
        }
        #endregion

    }
}

