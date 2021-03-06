using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Data.Json;
using Newtonsoft.Json;
using openhabUWP.Helper;

namespace openhabUWP.Remote.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Widget : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets the widget identifier.
        /// </summary>
        /// <value>
        /// The widget identifier.
        /// </value>
        public string WidgetId { get; set; }
        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        public string Icon { get; set; }
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string Label { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the widgets.
        /// </summary>
        /// <value>
        /// The widgets.
        /// </value>
        public List<Widget> Widgets { get; set; }
        /// <summary>
        /// Gets or sets the item.
        /// </summary>
        /// <value>
        /// The item.
        /// </value>
        public Item Item { get; set; }
        /// <summary>
        /// Gets or sets the linked page.
        /// </summary>
        /// <value>
        /// The linked page.
        /// </value>
        public Page LinkedPage { get; set; }
        /// <summary>
        /// Gets or sets the mappings.
        /// </summary>
        /// <value>
        /// The mappings.
        /// </value>
        public Mapping[] Mappings { get; set; }
        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        public string[] Tags { get; set; }
        /// <summary>
        /// Gets or sets the group names.
        /// </summary>
        /// <value>
        /// The group names.
        /// </value>
        public string[] GroupNames { get; set; }

        /*chart,webview,mapview widget*/
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public double Height { get; set; }


        /*chart widget*/
        /// <summary>
        /// Gets or sets the refresh.
        /// </summary>
        /// <value>
        /// The refresh.
        /// </value>
        public double Refresh { get; set; }
        /// <summary>
        /// Gets or sets the period.
        /// </summary>
        /// <value>
        /// The period.
        /// </value>
        public string Period { get; set; }


        /*setpoint*/
        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public double MinValue { get; set; }
        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public double MaxValue { get; set; }
        /// <summary>
        /// Gets or sets the step.
        /// </summary>
        /// <value>
        /// The step.
        /// </value>
        public double Step { get; set; }


        /*url*/
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Widget"/> class.
        /// </summary>
        public Widget()
        {
            if (!DesignMode.DesignModeEnabled) this.Widgets = new List<Widget>();
            this.Item = new Item();
            this.LinkedPage = new Page();
            this.Mappings = new Mapping[0];
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Widget"/> class.
        /// </summary>
        /// <param name="widgetId">The widget identifier.</param>
        /// <param name="label">The label.</param>
        /// <param name="type">The type.</param>
        /// <param name="icon">The icon.</param>
        public Widget(string widgetId, string label, string type, string icon) : this()
        {
            this.WidgetId = widgetId;
            this.Icon = icon;
            this.Label = label;
            this.Type = type;
        }

        public bool Equals(Widget widget)
        {
            return this.WidgetId == widget.WidgetId;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Updated()
        {
            OnPropertyChanged("Self");
        }

        [JsonIgnore]
        public Widget Self
        {
            get { return this; }
        }
    }
}