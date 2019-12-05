using System;
using System.Collections.Generic;
using System.Linq;


namespace MyBigNotebook
{
    /// <summary>
    /// Раздел планы
    /// </summary>
    [Serializable]
    public class ClassPlants :ICrypt
    {
        /// <summary>
        /// Планы на будущее
        /// </summary>
        public List<FuturePlan> FuturePlans;
        /// <summary>
        /// Цели
        /// </summary>
        public List<Target> Targets;
        /// <summary>
        /// Список закупок
        /// </summary>
        public List<ShoppingList> ShoppingLists;
        /// <summary>
        /// Проекты
        /// </summary>
        public List<Project> Projects;

        public ClassPlants()
        {
            FuturePlans = new List<FuturePlan>();
            Targets = new List<Target>();
            ShoppingLists = new List<ShoppingList>();
            Projects = new List<Project>();
        }
        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns>Истина, если удачно</returns>
        public bool Decrypt()
        {
            try
            {
                foreach (FuturePlan futurePlan in FuturePlans)
                    futurePlan.Decrypt();
                foreach (Target target in Targets)
                    target.Decrypt();
                foreach (ShoppingList shopping in ShoppingLists)
                    shopping.Decrypt();
                foreach (Project project in Projects)
                    project.Decrypt();

                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// Шифрование
        /// </summary>
        /// <returns>Истина, если удачно</returns>
        public bool Encrypt()
        {
            try
            {
                foreach (FuturePlan futurePlan in FuturePlans)
                    futurePlan.Encrypt();
                foreach (Target target in Targets)
                    target.Encrypt();
                foreach (ShoppingList shopping in ShoppingLists)
                    shopping.Encrypt();
                foreach (Project project in Projects)
                    project.Encrypt();

                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// Планы на будущее
    /// </summary>
    [Serializable]
    public class FuturePlan :ICrypt
    {
        /// <summary>
        /// Название плана
        /// </summary>
        public string NamePlan;
        /// <summary>
        /// Дата реализации
        /// </summary>
        public DateTime DateRealise;
        /// <summary>
        /// Пункты плана
        /// </summary>
        public List<PunktOfPlan> punktOfPlans;

        public FuturePlan()
        {
            NamePlan = "";
            DateRealise = DateTime.Now;
            punktOfPlans = new List<PunktOfPlan>();
            
        }

        public FuturePlan(string name)
        {
            NamePlan = name;
            DateRealise = DateTime.Now;
            punktOfPlans = new List<PunktOfPlan>();

        }

        public bool Decrypt()
        {
            try
            {
                NamePlan = ClassCrypt.Decrypt(NamePlan);
                foreach (PunktOfPlan punkt in punktOfPlans)
                    punkt.Decrypt();

                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NamePlan = ClassCrypt.Encrypt(NamePlan);
                foreach (PunktOfPlan punkt in punktOfPlans)
                    punkt.Encrypt();

                return true;
            }
            catch { return false; }
        }

        public int getNewNumberPunkk()
        {
            int a = punktOfPlans.Max(p => p.NumberPunkt);
            return a + 1;
        }
    }

    /// <summary>
    /// Пункт Плана
    /// </summary>
    [Serializable]
    public class PunktOfPlan :ICrypt
    {
       
        /// <summary>
        /// № пункта
        /// </summary>
        public int NumberPunkt;
        /// <summary>
        /// Название пункта
        /// </summary>
        public string NamePunkt;
        /// <summary>
        /// Флаг выполнения
        /// </summary>
        public bool CompleteFlag;

        public PunktOfPlan()
        {          
            NumberPunkt = 0;
            NamePunkt = "";
            CompleteFlag = false;
        }

        public PunktOfPlan(int number, string name, bool complete)
        {
            NumberPunkt = number;
            NamePunkt = name;
            CompleteFlag = complete;
        }


        public bool Encrypt()
        {
            try
            {
                NamePunkt = ClassCrypt.Encrypt(NamePunkt);
                return true;
            }
            catch { return false; }
        }
        public bool Decrypt()
        {
            try
            {
                NamePunkt = ClassCrypt.Decrypt(NamePunkt);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Шаг достижения цели
    /// </summary>
    [Serializable]
    public class Step :ICrypt
    {
        /// <summary>
        /// № шага
        /// </summary>
        public int NumberStep;
        /// <summary>
        /// Название шага
        /// </summary>
        public string NameStep;
        /// <summary>
        /// Описание шага
        /// </summary>
        public string DescriptionStep;        
        /// <summary>
        /// Флаг о завершении
        /// </summary>
        public bool CompleteFlag;

        public Step()
        {
            NumberStep = 0;
            NameStep = "";
            DescriptionStep = "";            
            CompleteFlag = false;
        }

        public Step(int number, string name, string description, bool complete)
        {
            NumberStep = number;
            NameStep = name;
            DescriptionStep = description;
            CompleteFlag = complete;
        }
        public bool Decrypt()
        {
            try
            {
                NameStep = ClassCrypt.Decrypt(NameStep);
                DescriptionStep = ClassCrypt.Decrypt(DescriptionStep);
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameStep = ClassCrypt.Encrypt(NameStep);
                DescriptionStep = ClassCrypt.Encrypt(DescriptionStep);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Цель
    /// </summary>
    [Serializable]
    public class Target :ICrypt
    {
        /// <summary>
        /// название
        /// </summary>
        public string NameTarget;
        /// <summary>
        /// Дата начала реализации
        /// </summary>
        public DateTime DateStartRealise;
        /// <summary>
        /// Дата окончания реализации
        /// </summary>
        public DateTime DateEndRealise;
        /// <summary>
        /// Описание
        /// </summary>
        public string DescriptionTarget;
        /// <summary>
        /// Шаги достижения
        /// </summary>
        public List<Step> Steps;
        /// <summary>
        /// Отметка о достижении
        /// </summary>
        public bool CompleteFlag;

        public Target()
        {
            NameTarget = "";
            DateStartRealise = DateTime.Now;
            DateEndRealise = DateTime.Now;
            DescriptionTarget = "";
            Steps = new List<Step>();
            CompleteFlag = false;
        }
        public Target(string name)
        {
            NameTarget = name;
            DateStartRealise = DateTime.Now;
            DateEndRealise = DateTime.Now;
            DescriptionTarget = "";
            Steps = new List<Step>();
            CompleteFlag = false;
        }
        public bool Decrypt()
        {
            try
            {
                NameTarget = ClassCrypt.Decrypt(NameTarget);
                DescriptionTarget = ClassCrypt.Decrypt(DescriptionTarget);
                foreach (Step step in Steps)
                    step.Decrypt();
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameTarget = ClassCrypt.Encrypt(NameTarget);
                DescriptionTarget = ClassCrypt.Encrypt(DescriptionTarget);
                foreach (Step step in Steps)
                    step.Encrypt();
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Список покупок
    /// </summary>
    [Serializable]
    public class ShoppingList :ICrypt
    {
        /// <summary>
        /// Название
        /// </summary>
        public string NameItem;
        /// <summary>
        /// Описание
        /// </summary>
        public string Description;
        /// <summary>
        ///Цена
        /// </summary>
        public double Cost;
        /// <summary>
        /// Отметка о покупке
        /// </summary>
        public bool CompleteFlag;

        public ShoppingList()
        {
            NameItem = "";
            Description = "";
            Cost = 0;
            CompleteFlag = false;
        }
        public ShoppingList(string name)
        {
            NameItem = name;
            Description = "";
            Cost = 0;
            CompleteFlag = false;
        }

        public bool Decrypt()
        {
            try
            {
                NameItem = ClassCrypt.Decrypt(NameItem);
                Description = ClassCrypt.Decrypt(Description);
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameItem = ClassCrypt.Encrypt(NameItem);
                Description = ClassCrypt.Encrypt(Description);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Проекты
    /// </summary>
    [Serializable]
    public class Project :ICrypt
    {
        /// <summary>
        /// Название проекта
        /// </summary>
        public string NameProject;
        /// <summary>
        /// Описание
        /// </summary>
        public string Description;
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime DateStart;
        /// <summary>
        /// Шаги реализации
        /// </summary>
        public List<ProjectStep> ProjectSteps;

        public Project()
        {
            NameProject = "";
            Description = "";
            DateStart = DateTime.Now;
            ProjectSteps = new List<ProjectStep>();
        }
        public Project(string name)
        {
            NameProject = name;
            Description = "";
            DateStart = DateTime.Now;
            ProjectSteps = new List<ProjectStep>();
        }
        public bool Decrypt()
        {
            try
            {
                NameProject = ClassCrypt.Decrypt(NameProject);
                Description = ClassCrypt.Decrypt(Description);
                foreach (ProjectStep step in ProjectSteps)
                    step.Decrypt();
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameProject = ClassCrypt.Encrypt(NameProject);
                Description = ClassCrypt.Encrypt(Description);
                foreach (ProjectStep step in ProjectSteps)
                    step.Encrypt();
                return true;
            }
            catch { return false; }
        }

    }

    [Serializable]
    /// <summary>
    /// пункт реализации проекта
    /// </summary>
    public class ProjectStep :ICrypt
    {
        /// <summary>
        /// Номер шага
        /// </summary>
        int NumberStep;
        /// <summary>
        /// наименование
        /// </summary>
        public string NameStep;
        /// <summary>
        /// Описание
        /// </summary>
        public string Description;
        /// <summary>
        /// Отметка о выполнении
        /// </summary>
        public bool CombleteFlag;

        public ProjectStep()
        {
            NumberStep = 0;
            NameStep = "";
            Description = "";
            CombleteFlag = false;
        }
        public bool Decrypt()
        {
            try
            {
                NameStep = ClassCrypt.Decrypt(NameStep);
                Description = ClassCrypt.Decrypt(Description);
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameStep = ClassCrypt.Encrypt(NameStep);
                Description = ClassCrypt.Encrypt(Description);
                return true;
            }
            catch { return false; }
        }
    }



}
