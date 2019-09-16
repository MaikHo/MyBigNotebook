using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigNotebook
{
    class ClassPlants
    {



    }

    /// <summary>
    /// Планы на будущее
    /// </summary>
    [Serializable]
    class FuturePlan
    {
        /// <summary>
        /// Название плана
        /// </summary>
        string NamePlan;
        /// <summary>
        /// Дата реализации
        /// </summary>
        DateTime DateRealise;
        /// <summary>
        /// Пункты плана
        /// </summary>
        List<PunktOfPlan> punktOfPlans;

        FuturePlan()
        {
            NamePlan = "";
            DateRealise = DateTime.Now;
            punktOfPlans = new List<PunktOfPlan>();
        }
    }

    /// <summary>
    /// Пункт Плана
    /// </summary>
    [Serializable]
    class PunktOfPlan
    {
        /// <summary>
        /// № пункта
        /// </summary>
        int NumberPunkt;
        /// <summary>
        /// Название пункта
        /// </summary>
        string NamePunkt;
        /// <summary>
        /// Флаг выполнения
        /// </summary>
        bool CompleteFlag;

        PunktOfPlan()
        {
            NumberPunkt = 0;
            NamePunkt = "";
            CompleteFlag = false;
        }
    }

    /// <summary>
    /// Шаг достижения цели
    /// </summary>
    [Serializable]
    class Step
    {
        /// <summary>
        /// № шага
        /// </summary>
        int NumberStep;
        /// <summary>
        /// Название шага
        /// </summary>
        string NameStep;
        /// <summary>
        /// Описание шага
        /// </summary>
        string DescriptionStep;
        /// <summary>
        /// продолжительность
        /// </summary>
        DateTime DurationStep;
        /// <summary>
        /// Флаг о завершении
        /// </summary>
        bool CompleteFlag;

        Step()
        {
            NumberStep = 0;
            NameStep = "";
            DescriptionStep = "";
            DurationStep = DateTime.Now;
            CompleteFlag = false;
        }
    }

    /// <summary>
    /// Цель
    /// </summary>
    [Serializable]
    class Target
    {
        /// <summary>
        /// название
        /// </summary>
        string NameTarget;
        /// <summary>
        /// Дата начала реализации
        /// </summary>
        DateTime DateStartRealise;
        /// <summary>
        /// Дата окончания реализации
        /// </summary>
        DateTime DateEndRealise;
        /// <summary>
        /// Описание
        /// </summary>
        string DescriptionTarget;
        /// <summary>
        /// Шаги достижения
        /// </summary>
        List<Step> Steps;
        /// <summary>
        /// Отметка о достижении
        /// </summary>
        bool CompleteFlag;

        Target()
        {
            NameTarget = "";
            DateStartRealise = DateTime.Now;
            DateEndRealise = DateTime.Now;
            DescriptionTarget = "";
            Steps = new List<Step>();
            CompleteFlag = false;
        }
    }

    


}
