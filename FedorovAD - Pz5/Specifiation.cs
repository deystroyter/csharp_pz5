using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedorovAD___Pz5
{
    public interface ISpecification<T>
    {
        /// <summary>
        /// Главный булевый метод для имплементации
        /// </summary>
        bool IsSatisfiedBy(T candidate);

        /// <summary>
        /// Булевый оператор И
        /// </summary>
        ISpecification<T> And(ISpecification<T> condition);

        /// <summary>
        /// Булевый оператор ИЛИ
        /// </summary>
        ISpecification<T> Or(ISpecification<T> condition);

        /// <summary>
        /// Булевый оператор НЕ
        /// </summary>
        ISpecification<T> Not();
    }

    /// <summary>
    /// Абстрактный класс с базовыми бинарными операциями
    /// </summary>
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// Наш главный булевый метод для реализации
        /// </summary>
        public abstract bool IsSatisfiedBy(T candidate);

        /// <summary>
        /// Реализация булевого оператор И
        /// </summary>
        /// <returns>this && condition</returns>
        public ISpecification<T> And(ISpecification<T> condition)
            => new AndSpecification<T>(this, condition);

        /// <summary>
        /// Реализация булевого оператор ИЛИ
        /// </summary>
        /// /// <returns>this || condition</returns>
        public ISpecification<T> Or(ISpecification<T> condition)
            => new OrSpecification<T>(this, condition);

        /// <summary>
        /// Реализация булевого оператор НЕ
        /// </summary>
        /// /// <returns>!this</returns>
        public ISpecification<T> Not()
            => new NotSpecification<T>(this);
    }

    public class OrSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        /// Первое состояние
        /// </summary>
        private readonly ISpecification<T> _firstCondition;

        /// <summary>
        /// Второе состояние
        /// </summary>
        private readonly ISpecification<T> _secondCondition;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstCondition">Первое состояние</param>
        /// <param name="secondCondition">Второе состояние</param>
        public OrSpecification(ISpecification<T> firstCondition, ISpecification<T> secondCondition)
        {
            _firstCondition = firstCondition;
            _secondCondition = secondCondition;
        }

        /// <summary>
        /// Реализация нашего главного булевого метода
        /// </summary>
        /// <returns>Первое состояние ИЛИ второе состояние удовлетворяет</returns>
        public override bool IsSatisfiedBy(T candidate)
        {
            return _firstCondition.IsSatisfiedBy(candidate) || _secondCondition.IsSatisfiedBy(candidate);
        }
    }


    public class NotSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        /// Состояние
        /// </summary>
        private readonly ISpecification<T> _condition;

        /// <summary>
        /// Конструктор
        /// </summary>
        public NotSpecification(ISpecification<T> condition)
        {
            _condition = condition;
        }

        /// <summary>
        /// Реализация главного булевого метода
        /// </summary>
        /// <returns>Состояние НЕ удовлетворяет</returns>
        public override bool IsSatisfiedBy(T candidate)
        {
            return !_condition.IsSatisfiedBy(candidate);
        }
    }

    public class AndSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        /// Первое состояние
        /// </summary>
        private readonly ISpecification<T> _firstCondition;

        /// <summary>
        /// Второе состояние
        /// </summary>
        private readonly ISpecification<T> _secondCondition;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstCondition">Первое состояние</param>
        /// <param name="secondCondition">Второе состояние</param>
        public AndSpecification(ISpecification<T> firstCondition, ISpecification<T> secondCondition)
        {
            _firstCondition = firstCondition;
            _secondCondition = secondCondition;
        }

        /// <summary>
        /// Реализация нашего главного булевого метода
        /// </summary>
        /// <returns>Первое состояние И второе состояние удовлетворяет</returns>
        public override bool IsSatisfiedBy(T candidate)
        {
            return _firstCondition.IsSatisfiedBy(candidate) && _secondCondition.IsSatisfiedBy(candidate);
        }
    }


}
