using AutoSalon.DAL;
using AutoSalon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon.Services
{
    public class ClientService : IClientService
    {
        private DbAutoSalonContext db;
        public ClientService(DbAutoSalonContext dbRepos)
        {
            db = dbRepos;
        }

        public List<Client> GetAllClients()
        {
            return db.Clients.ToList();
        }


        public Client GetClient(int Id)
        {
            return db.Clients.Find(Id);
        }

        public void CreateClient(Client p)
        {
            Client client = new Client();

            client.Id = p.Id;
            client.Name = p.Name;
            client.Surname = p.Surname;
            client.Phonenumber = p.Phonenumber;
            client.Address = p.Address;
            client.Passport = p.Passport;
            client.Cars = p.Cars;
            client.CarsNames = p.CarsNames;

            db.Clients.Add(client);
            db.SaveChanges();
        }

        public void UpdateClient(Client p)
        {

            Client client = db.Clients.Find(p.Id);

            if (p != null)
            {
                client.Id = p.Id;
                client.Name = p.Name;
                client.Surname = p.Surname;
                client.Phonenumber = p.Phonenumber;
                client.Address = p.Address;
                client.Passport = p.Passport;
                client.Cars = p.Cars;
                client.CarsNames = p.CarsNames;

                db.SaveChanges();
            }
        }

        public void DeleteClient(int id)
        {
            Client p = db.Clients.Find(id);
            if (p != null)
            {
                db.Clients.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
