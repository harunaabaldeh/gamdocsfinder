import React from 'react'

function DocsCard() {
    return (
        <div className="bg-white shadow-md rounded-lg max-w-sm dark:bg-gray-800 dark:border-gray-700">
            <a href="#" className='h-2/5'>
                <img className="rounded-t-lg p-8" src="/assets/passport.jpeg" alt="docs image" />
            </a>
            <div className="px-5 pb-5">
                <a href="#">
                    <h3 className="text-gray-900 font-semibold text-xl tracking-tight dark:text-white">found by fabala at taboku 5 days ago</h3>
                </a>
                <div className="flex items-center mt-2.5 mb-5">
                    view
                    <span className="bg-blue-100 text-blue-800 text-xs font-semibold mr-2 px-2.5 py-0.5 rounded dark:bg-blue-200 dark:text-blue-800 ml-3">5k</span>
                </div>
                <div className="flex items-center justify-between">
                    <span className="text-3xl font-bold text-gray-900 dark:text-white">Owner's name</span>
                    <a href="#"
                        className="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">doc details</a>
                </div>
            </div>
        </div>
    )
}

export default DocsCard