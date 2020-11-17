using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaProblems.Data;
using PizzaProblems.DTOs;
using PizzaProblems.Modles;

namespace PizzaProblems.Controllers
{
    [ApiController]
    [Route("api/pizzas")]
    public class PizzasController : ControllerBase
    {
        private readonly IPizzaRepo _repository;
        private IMapper _mapper;

        public PizzasController(IPizzaRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        // GET https://localhost:5001/api/pizzas/
        [HttpGet]
        public ActionResult <IEnumerable<PizzaReadDtos>> GetPizzaTypes()
        {
            var pizzaTypes = _repository.GetPizzaTypes();
            return Ok(_mapper.Map<IEnumerable<PizzaReadDtos>>(pizzaTypes));
        }
        // GET https://localhost:5001/api/pizzas/id
        
        [HttpGet("{id}", Name="GetPizzaById")]
        public ActionResult<PizzaReadDtos> GetPizzaById(int id)
        {
            var pizza = _repository.GetPizzaById(id);
            if (pizza != null)
            {
                return Ok(_mapper.Map<PizzaReadDtos>(pizza));
            }
            return NotFound();
        }
        
        // POST https://localhost:5001/api/pizzas/
        [HttpPost]
        public ActionResult<PizzaReadDtos> CreatePizza(PizzaCreateDto pizzaCreateDto){
            
            var pizzaModel = _mapper.Map<Pizza>(pizzaCreateDto);
            _repository.CreatePizza(pizzaModel);
            _repository.saveChanges();

            var pizzaReadDto = _mapper.Map<PizzaReadDtos>(pizzaModel);
            
            return CreatedAtRoute(nameof(GetPizzaById),new {id = pizzaReadDto.id},pizzaReadDto);
        }
        
        //PUT https://localhost:5001/api/pizzas/id
        [HttpPut("{id}")]
        public ActionResult updatePizza(int id, PizzaUpdateDto pizzaUpdateDto){
            var pizzaFromRepo = _repository.GetPizzaById(id);
            if(pizzaFromRepo == null){
                return NotFound();
            }
            
            //updating model happens here
            _mapper.Map(pizzaUpdateDto,pizzaFromRepo);
            
            //good practice
            _repository.updatePizza(pizzaFromRepo);

            _repository.saveChanges();

            return NoContent();
        }
        
        // DELETE https://localhost:5001/api/pizzas/id
        [HttpDelete("{id}")]
        public ActionResult DeletePizza(int id){
           var pizzaFromRepo = _repository.GetPizzaById(id);
            if(pizzaFromRepo == null){
                return NotFound();
            }
            _repository.deletePizza(pizzaFromRepo);
            _repository.saveChanges();

            return NoContent();
        }

    }
}