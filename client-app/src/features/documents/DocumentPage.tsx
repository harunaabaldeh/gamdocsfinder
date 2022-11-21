import React from 'react'
import DocsCard from './docsCard'

function DocumentPage() {
    return (
        <section className="min-h-screen body-font text-gray-600 ">
            <div className="container mx-auto px-5 py-10">
                <div className="-m-4 flex flex-wrap">
                    {/* display docCard 8 times */}
                    {
                        [1, 2, 3, 4, 5, 6, 7, 8].map((item) => (
                            <div className="p-4 md:w-1/3">
                                <DocsCard />
                            </div>
                        ))
                    }
                </div>
            </div>
        </section>
    )
}

export default DocumentPage