using AutoMapper;
using System.Reflection;
using WebsiteDemo.Interfaces;


namespace WebsiteDemo.Services
{
    public class MappingService : IMappingService
    {

        private readonly IMapper _mapper;

        public MappingService(IMapper mapper)
        {

            _mapper = mapper;
        }

        public TReturn MapContent<T, TReturn>(T content) where T : class
        {


            var mappedContent = _mapper.Map<T, TReturn>(content);


            return mappedContent;

        }

    }

}
