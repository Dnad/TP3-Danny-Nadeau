using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorat.appl.Controller
{
    class SessionController
    {
        private readonly IEntityRepository<TutoringSession> _sessionRepository;

        public SessionController(IEntityRepository<TutoringSession> _repository)
        {
            _sessionRepository = _repository;
        }

        void ListAll()
        {

        }
    }
}
