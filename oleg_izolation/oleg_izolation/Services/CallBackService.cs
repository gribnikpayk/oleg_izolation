using System;
using System.Collections.Generic;
using System.Linq;
using oleg_izolation.Context;
using oleg_izolation.Models;

namespace oleg_izolation.Services
{
    public class CallBackService
    {
        public void AddCallBackToDB(CallBackModel model)
        {
            using (var context = new CallBackContext())
            {
                model.Date = DateTime.Now;
                context.CallBackModels.Add(model);
                context.SaveChanges();
            }
        }

        public List<CallBackModel> GetCallBackModels()
        {
            using (var context = new CallBackContext())
            {
                return context.CallBackModels.OrderBy(x => x.Date).ToList();
            }
        }
    }
}