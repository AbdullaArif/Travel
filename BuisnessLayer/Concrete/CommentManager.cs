﻿using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{

    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void TAdd(Comment item)
        {
           _commentDal.Insert(item);
        }

        public void TDelete(Comment item)
        {
           _commentDal.Delete(item);
        }

        public Comment TGetById(int id)
        {
           return _commentDal.GetById(id);
        }

        public List<Comment> TGetList()
        {
           return _commentDal.GetList();
        }

        public List<Comment> TGetDestinationById(int id) 
        { return _commentDal.GetListByFilter(x => x.DestinationId == id); }

        public void TUpdate(Comment item)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }
    }
}
