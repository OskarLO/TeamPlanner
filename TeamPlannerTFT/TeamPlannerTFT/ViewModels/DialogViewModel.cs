using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamPlannerTFT.Core.Dtos;
using TeamPlannerTFT.DataAccess.Model;

namespace TeamPlannerTFT.ViewModels
{
    public class DialogViewModel : ObservableValidator
    {
        private readonly UnitDto _unitDto;

        private readonly List<ValidationResult> _errors = new();
        public string Errors => string.Join(Environment.NewLine, from ValidationResult e in _errors select e.ErrorMessage);
        public new bool HasErrors => Errors.Length > 0;

        public DialogViewModel()
        {
            _unitDto = new UnitDto();
            ValidateAllProperties();
            _errors.AddRange(GetErrors());
        }

        public DialogViewModel(UnitDto unitDto)
        {
            _unitDto = unitDto;
            ValidateAllProperties();
            _errors.AddRange(GetErrors());
        }

        public static explicit operator UnitDto(DialogViewModel c) => new()
        {
            Id = c.Id,
            Name = c.Name,
            Cost = c.Cost,
            Mana = c.Mana,
            UnitImage = c.UnitImage
        };

        public int Id
        {
            get => _unitDto.Id;
            set => SetProperty(_unitDto.Id, value, _unitDto, (_unit, id) => _unit.Id = value);
        }

        public string Name
        {
            get => _unitDto.Name;
            set => SetProperty(_unitDto.Name, value, (name) => _unitDto.Name = name);
        }

        public int Cost
        {
            get => _unitDto.Cost;
            set => SetProperty(_unitDto.Cost, value, _unitDto, (_unit, cost) => _unit.Cost = value);
        }

        public int Mana
        {
            get => _unitDto.Mana;
            set => SetProperty(_unitDto.Mana, value, _unitDto, (_unit, mana) => _unit.Mana = value);
        }

        public string UnitImage
        {
            get => _unitDto.UnitImage;
            set => SetProperty(_unitDto.UnitImage, value, (unitImage) => _unitDto.UnitImage = unitImage);
        }

        public List<TraitDto> Traits
        {
            get => _unitDto.Traits;
            set => SetProperty(_unitDto.Traits, value, (traits) => _unitDto.Traits = traits);
        }
    }
}
