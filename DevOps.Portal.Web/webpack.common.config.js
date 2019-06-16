const path = require('path');
const webpack = require('webpack');
const CleanWebpackPlugin = require('clean-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
    entry: {
        app: './ClientApp/main.ts',
        polyfills: './ClientApp/polyfills.ts'
    },
    output: {
        path: path.resolve(__dirname, 'wwwroot/'),
        filename: 'dist/[name].bundle.js',
        chunkFilename: 'dist/[id].chunk.js',
        publicPath: '/'
    },
    resolve: {
        // Add `.ts` and `.tsx` as a resolvable extension.
        extensions: [".ts", ".tsx", ".js"]
    },
    module: {
        rules: [
            // all files with a `.ts` or `.tsx` extension will be handled by `ts-loader`
            { 
                test: /\.tsx?$/, 
                use: [
                    {
                        loader: "ts-loader"
                    },
                    {
                        loader: "angular2-template-loader"
                    }
                ]
            },
            {
                test: /\.(html|css)$/, 
                use: 'raw-loader'
            }
        ]
    },
    plugins: [
        new CleanWebpackPlugin(['wwwroot/dist']),
        new webpack.ProvidePlugin({
            $: 'jquery',
            jQuery: 'jquery',
            "window.jQuery": "jquery"
        }),
        new HtmlWebpackPlugin({
            inject: "body",
            filename: "../Views/Shared/_Layout.cshtml",
            template: 'ClientApp/index.html'
        })
    ]
}