namespace ScanUploader.Properties {
    
    
    // 通过此类可以处理设置类的特定事件: 
    //  在更改某个设置的值之前将引发 SettingChanging 事件。
    //  在更改某个设置的值之后将引发 PropertyChanged 事件。
    //  在加载设置值之后将引发 SettingsLoaded 事件。
    //  在保存设置值之前将引发 SettingsSaving 事件。
    internal sealed partial class URL {
        
        public URL() {
            // // 若要为保存和更改设置添加事件处理程序，请取消注释下列行: 
            //
             //this.SettingChanging += this.SettingChangingEventHandler;
            //
             this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // 在此处添加用于处理 SettingChangingEvent 事件的代码。
        }
        
        /// <summary>
        /// 处理 SettingsSaving 事件
        /// </summary>
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            
            //更新扫码上传URL
            //-载具扫出
            Model.URL.scanContainerOut = this.prefix + this.subPrefix_MES + this.postfix_scanContainerOut;
            //-单片玻璃
            Model.URL.scanSn = this.prefix + this.subPrefix_MES + this.postfix_scanSn;
            //-载具扫入
            Model.URL.scanContainerIn = this.prefix + this.subPrefix_MES + this.postfix_scanContainerIn;
            //-载具解绑
            Model.URL.scanContainerUnbind = this.prefix + this.subPrefix_MES + this.postfix_scanContainerUnbind;
            //-提交
            Model.URL.scanSubmit = this.prefix + this.subPrefix_MES + this.postfix_submit;
    }
    }
}
