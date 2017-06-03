﻿namespace MGraph
{
    /// <summary>
    /// Directed Edge class.
    /// </summary>
    public class Edge<TVertex> : IEdge<TVertex>
    {
        Label _label;
        protected readonly TVertex _source;
        protected readonly TVertex _target;

        /// <summary>
        /// Initializes a new instance of the Edge class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="target">The target.</param>
        public Edge(TVertex source, TVertex target)
        {
            this._source = source;
            this._target = target;
            _label = new Label();
        }

        /// <summary>
        /// Gets the source vertex
        /// </summary>
        /// <value></value>
        public TVertex source
        {
            get { return this._source; }
        }

        /// <summary>
        /// Gets the target vertex
        /// </summary>
        /// <value></value>
        public TVertex target
        {
            get { return this._target; }
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(label.Text))
                return this.source.ToString() + "- [" + _label.Text + "]->" + this.target.ToString();
            else
                return this.source.ToString() + "-->" + this.target.ToString();
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        public Label label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
            }
        }
    }
}
