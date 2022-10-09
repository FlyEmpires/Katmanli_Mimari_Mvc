﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class MessageManager: IMessageService
    {
        Context ctx = new Context();

        IMessageDal _Messagedal;

        public MessageManager(IMessageDal Messagedal)
        {
            _Messagedal = Messagedal;
        }

        public Message GetByID(int id)
        {
            return _Messagedal.Get(x => x.MessageID == id);

        }

        public List<Message> GetListInbox()
        {
            return _Messagedal.List(x => x.ReceiverMail == "mehmet@hotmail.com");
        }

        
        public List<Message> GetListSendbox()
        {
            return _Messagedal.List(x=>x.SenderMail== "gizem@gmail.com");
        }

       

        public void MessageAdd(Message message)
        {
            _Messagedal.Insert(message);
        }
        
     

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
