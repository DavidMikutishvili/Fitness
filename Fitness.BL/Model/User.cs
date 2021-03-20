﻿using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Пользователь. 
    /// </summary>
    public class User
    {
        #region Properties
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="gender"> Пол. </param>
        /// <param name="birthDate"> Дата рождения. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            #region Checking the conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The user name cannot be empty or null.", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("The gender cannot be null.", nameof(gender));
            }

            if (birthDate < DateTime.Parse( "01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Impossible date of birth.", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("The weight cannot be greater than or equal to zero.", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentException("The height cannot be greater than or equal to zero.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name; 
        }
    }
}