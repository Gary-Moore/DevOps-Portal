const path = require('path');
const webpack = require('webpack');
const merge = require('webpack-merge');
const common = require('./webpack.common.config.js');

module.exports = merge(common, {
    mode: 'development',
    module: {
        rules: [
            //{
            //    test: /\.(s*)css$/,
            //    include: path.join(path.resolve(__dirname, 'ClientApp/styles')),
            //    use: [
            //        {
            //            loader: 'style-loader'
            //        },
            //        {
            //            loader: 'css-loader'
            //        }, 
            //        {
            //            loader: 'sass-loader'
            //        }
            //    ]

            //}
        ]
    }
});