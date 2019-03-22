﻿using NTMiner.Views.Ucs;
using System.Windows;
using System.Windows.Input;

namespace NTMiner.Vms {
    public class ConsoleViewModel : ViewModelBase {
        public ICommand CustomTheme { get; private set; }
        public ConsoleViewModel() {
            this.CustomTheme = new DelegateCommand(() => {
                LogColor.ShowWindow();
            });
            VirtualRoot.On<MineStartedEvent>(
                "挖矿开始后因此日志窗口的水印",
                LogEnum.Console,
                action: message => {
                    this.IsWatermarkVisible = Visibility.Collapsed;
                });
        }

        private Visibility _isWatermarkVisible = Visibility.Visible;
        public Visibility IsWatermarkVisible {
            get {
                return _isWatermarkVisible;
            }
            set {
                if (_isWatermarkVisible != value) {
                    _isWatermarkVisible = value;
                    OnPropertyChanged(nameof(IsWatermarkVisible));
                }
            }
        }

        public MinerProfileViewModel MinerProfile {
            get {
                return MinerProfileViewModel.Current;
            }
        }
    }
}
